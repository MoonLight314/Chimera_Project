using System;
using Chimera.Library.Environment;
using Chimera.Library.Wallpaper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace Chimera
{
    public partial class SettingWallpaper : Form
    {

        /*  */
        private Controller controller = new Controller();
        private Image wallpaper = null;

        private List<int> selectedScreens = new List<int>();
        private Rectangle previewRect;

        private Point point;

        IList<DisplayDevice> allMonitorInfo;

        public SettingWallpaper( IList<DisplayDevice> allMonitorProperties)
        {
            InitializeComponent();

            allMonitorInfo = allMonitorProperties;

            FillFitCombo();
            CalcPreviewRect();
            CreateWallpaper();

            // automatically select the first screen
            AddSelectedScreen(0);

            //this.Paint += new PaintEventHandler(set_background);
            
        }



        private void FillFitCombo()
        {
            comboBoxFit.Items.Add(new Stretch(Stretch.Fit.Center));
            comboBoxFit.Items.Add(new Stretch(Stretch.Fit.StretchToFit));
            comboBoxFit.Items.Add(new Stretch(Stretch.Fit.OverStretch));
            comboBoxFit.Items.Add(new Stretch(Stretch.Fit.UnderStretch));
            comboBoxFit.SelectedIndex = 0;  // select Center by default
        }



        private void CalcPreviewRect()
        {
            Size sourceSize = controller.DesktopRect.Size;
            Rectangle pictureBoxRect = new Rectangle(new Point(0, 0), Preview_PictureBox.Size);
            // reduce preview size if needed to maintain aspect ratio
            previewRect = Controller.UnderStretch(sourceSize, pictureBoxRect);
        }


        /*  */
        private void set_background(Object sender, PaintEventArgs e)
        {

            this.BackColor = Color.FromArgb(35, 35, 35);

            //Graphics graphics = e.Graphics;

            ////the rectangle, the same size as our Form
            //Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            ////define gradient's properties            
            //Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 255, 255), Color.FromArgb(230, 230, 240), 65f);
            ////Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 255, 255), Color.FromArgb(100, 100, 100), 65f);

            ////apply gradient        
            //graphics.FillRectangle(b, gradient_rectangle);

        }




        private void CreateWallpaper()
        {
            if( wallpaper != null )
            {
                wallpaper.Dispose();
            }
            wallpaper = controller.CreateWallpaperImage();

            wallpaper.Save("wallpaper.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }



        private bool IsScreenSelected(int screenIndex)
        {
            bool selected = false;

            foreach (int screen in selectedScreens)
            {
                if (screen == screenIndex)
                {
                    selected = true;
                    break;
                }
            }

            return selected;
        }




        private void DisplaySelectedScreens()
        {
            string screenText = "";
            string FriendlyName = "";

            foreach (int screen in selectedScreens)
            {
                FriendlyName = GetMonitorFriendlyName( Screen.AllScreens[screen] );

                if (screenText.Length > 0)
                {
                    screenText += ", ";
                }
                screenText += String.Format("{0} : {1}", screen + 1 , FriendlyName );
            }

            labelScreensSelected.Text = screenText;
            
        }



        /*  */
        string GetMonitorFriendlyName( Screen selectedscreen )
        {
            foreach( DisplayDevice dd in allMonitorInfo )
            {
                if( dd.IsActive )
                {
                    if (dd.SourceName == selectedscreen.DeviceName)
                        return dd.FriendlyName;
                }
            }

            return "";
        }





        private void DisplayMonitor(Graphics g, Size previewSize, Rectangle screenRect, int screenIndex, string screenName)
        {
            Rectangle previewRect = new Rectangle(new Point(0, 0), previewSize);

            // need to determine position of screen rect in the preview
            Rectangle previewScreen = Controller.CalcDestRect(controller.DesktopRect, previewRect, screenRect);

            // TODO: look into this!
            previewScreen = new Rectangle(previewScreen.Left, previewScreen.Top, previewScreen.Width - 1, previewScreen.Height - 1);

            // draw border around screen
            Pen borderPen1 = Pens.Black;
            Pen borderPen2 = Pens.White;
            Brush textBrush = Brushes.White;

            if (IsScreenSelected(screenIndex))
            {
                borderPen1 = Pens.Yellow;
                borderPen2 = Pens.Yellow;
                textBrush = Brushes.Yellow;
            }
            // leave outermost pixels of image visible
            previewScreen.Inflate(-1, -1);
            g.DrawRectangle(borderPen1, previewScreen);
            previewScreen.Inflate(-1, -1);
            g.DrawRectangle(borderPen2, previewScreen);

            // display the screen name centered in the screen
            using (Font font = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Point))
            {
                g.DrawString(screenName, font, textBrush, previewScreen);
            }
        }








        private void DisplayMonitors(Graphics g, Size previewSize)
        {
            for (int screenIndex = 0; screenIndex < controller.AllScreens.Count; screenIndex++)
            {
                string screenName = string.Format("{0}", screenIndex + 1);
                if (controller.AllScreens[screenIndex].Primary)
                {
                    screenName += "P";
                }
                DisplayMonitor(g, previewSize, controller.AllScreens[screenIndex].ScreenRect, screenIndex, screenName);
            }
        }





        private void UpdatePreview()
        {
            DisplaySelectedScreens();

            Image preview = new Bitmap(previewRect.Width, previewRect.Height);

            using (Graphics g = Graphics.FromImage(preview))
            {
                g.DrawImage(wallpaper, 0, 0, preview.Width, preview.Height);

                // now indicate the positions of the monitors
                DisplayMonitors(g, preview.Size);

            }

            // display preview
            if(Preview_PictureBox.Image != null )
            {
                Preview_PictureBox.Image.Dispose();
            }
            Preview_PictureBox.Image = preview;
        }





        private void OnSeclectedScreensChanged()
        {
            controller.SetActiveScreens(selectedScreens);
            UpdatePreview();
        }



        private void AddSelectedScreen(int screenIndex)
        {
            if( !IsScreenSelected( screenIndex ) )
            {
                selectedScreens.Add( screenIndex );
                OnSeclectedScreensChanged();
            }
        }



        /*  종료 버튼 */
        private void ID_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /* Wallpaer Image File Browse 버튼 */
        private void Button_Browse_Wallpaper_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            /* Resource 추가 방법
             * https://dlwodus.tistory.com/211
             *  */           
            
            dlg.Filter = Properties.Resources.OpenImageFilter;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TextBox_Image_File_Path.Text = dlg.FileName;

                try
                {                    
                    //picSource.Image = LoadImageFromFile( TextBox_Image_File_Path.Text );
                    //picSource.SizeMode = PictureBoxSizeMode.Zoom;

                    ApplyImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, /*Program.MyTitle*/ "Error");
                }
            }
        }




        private Image LoadImageFromFile(string imageFilename)
        {
            Image image;

            // Solution 1
            // This keeps the file open which causes a problem
            // if we try to save the wallpaper back here later on

            //image = Bitmap.FromFile( TextBox_Image_File_Path.Text );
            image = Bitmap.FromFile( imageFilename );

            // Solution 2
            //// the following seems to work, but is not recommened as the documentation
            //// for Image.FromStream() says:
            //// 'You must keep the stream open for the lifetime of the Image'
            //using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(imageFilename)))
            //{
            //    return Image.FromStream(stream);
            //}

            // Solution 3
            //// This leaves the stream open so will work and adhere to the documentation, 
            //// but results in a memory leak.
            //MemoryStream stream = new MemoryStream(File.ReadAllBytes(imageFilename));
            //image = new Image.FromStream(stream);

            // Solution 4
            // some people have suggested copying the image to a secondary image
            // using either Clone() or a copy ctor() and returning that 
            // but the documentation doesn't make it clear if the cloned image
            // still has a reference to the original stream

            // Solution 5
            // Create a class that encapsulates both the image and the stream
            // Trouble is the PictureBox wants an image, so you need to manage 
            // the lifetime of the new object and make sure it isn't destroyed
            // while the PictureBox is still using the Image in it.

            return image;
        }





        private void ApplyImage()
        {
            if( TextBox_Image_File_Path.Text.Length > 0 )
            {
                // load image file
                try
                {
                    Image image = LoadImageFromFile(TextBox_Image_File_Path.Text);
                    Stretch stretchType = comboBoxFit.SelectedItem as Stretch;
                    //Debug.Assert(stretchType != null);
                    controller.AddImage(image, stretchType.Type);

                    CreateWallpaper();
                    UpdatePreview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.ApplicationName);
                }
            }
        }







        private void Set_Wallpaper_Click(object sender, EventArgs e)
        {
            ILocalEnvironment localEnvironment = new LocalEnvironment();
            WindowsWallpaper windowsWallpaper = new WindowsWallpaper(localEnvironment, wallpaper, controller.DesktopRect);
            windowsWallpaper.SetWallpaper(false);
        }




        private int PosnToScreen(int x, int y)
        {
            int ret = -1;

            if (previewRect.Contains(x, y))
            {
                // now map this onto the virtual desktop
                Point desktopPoint = Controller.CalcDestPoint(previewRect, controller.DesktopRect, new Point(x, y));

                // now check each screen to see if it contains this point
                for (int screenIndex = 0; screenIndex < controller.AllScreens.Count; screenIndex++)
                {
                    if (controller.AllScreens[screenIndex].ScreenRect.Contains(desktopPoint.X, desktopPoint.Y))
                    {
                        ret = screenIndex;
                        break;
                    }
                }
            }
            return ret;
        }





        private void RemoveSelectedScreen(int screenIndex)
        {
            // always want at least one screen selected
            if (selectedScreens.Count > 1)
            {
                selectedScreens.Remove(screenIndex);
                OnSeclectedScreensChanged();
            }
        }





        private void picPreview_MouseClick(object sender, MouseEventArgs e)
        {
            // check if the area clicked belongs to one of the screens
            int screenIndex = PosnToScreen(e.X, e.Y);

            if (screenIndex >= 0)
            {
                if ((Control.ModifierKeys & Keys.Control) != 0)
                {
                    // control pressed down - add screen to current list
                    if (IsScreenSelected(screenIndex))
                    {
                        // already selected - so remove (unless it is the only selected screen)
                        RemoveSelectedScreen(screenIndex);
                    }
                    else
                    {
                        AddSelectedScreen(screenIndex);
                    }
                }
                else
                {
                    // replace current screen list with screen just clicked
                    selectedScreens.Clear();
                    AddSelectedScreen(screenIndex);
                }
            }
        }





        private void ChangedStretchMode(object sender, EventArgs e)
        {

            if ( comboBoxFit.SelectedIndex >= 0 )
            {
                ApplyImage();
            }
        }

        private void titlebar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }


        private void titlebar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }





        private void titlebar_label_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }



        private void titlebar_label_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }
    }
}
