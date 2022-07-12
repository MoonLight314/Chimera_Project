using System;
using Chimera.Library.Environment;
using Chimera.Library.Wallpaper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Chimera.Library.PInvoke;
using Chimera.Library.Settings;
using Chimera.Library.Transform;

namespace Chimera
{
    public partial class SettingWallpaper : Form
    {

        /*  */
        private Controller controller = new Controller();

        private Image Wallpaper = null;
        private Image Wallpaper_Preview = null;

        private List<int> selectedScreens = new List<int>();
        private Rectangle previewRect;

        private int clickedScreenIndex;     /* Picture Preview 화면에서 선택된 Screen의 Index */

        IList<DisplayDevice> allMonitorInfo;

        public SettingWallpaper(IList<DisplayDevice> allMonitorProperties)
        {
            InitializeComponent();

            allMonitorInfo = allMonitorProperties;

            /*  기존에 적용되었던 Wallpaper의 Image가 있으면 그 Image들을 읽어서 초기화 한다.   */
            LoadPreviousWallpaper();

            /* Adjust Screen Rect */
            AdjustScreenRect();

            InitUI();

            /* 최초 실행시에 아무 Monitor도 선택되지 않도록 하기 위한 수정 */
            UpdatePreview();
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        private void AdjustScreenRect()
        {
            foreach (ScreenMapping sm in controller.AllScreens )
            {
                foreach(DisplayDevice dd in allMonitorInfo)
                {
                    /* 크기가 다른 Screen의 경우에는 Screen Rect를 Update한다. */
                    if(sm.UniqueDeviceID == dd.UniqueDeviceID)
                    {
                        ;
                    }
                    
                }
            }
        }









        /// <summary>
        /// 기존에 적용되었던 Wallpaper의 Image가 있으면 그 Image들을 읽어서 초기화 한다
        /// </summary>
        /// <param name=""></param>
        private void LoadPreviousWallpaper()
        {
            string FolderName , StretchType , ImageFilePath;
            string AppDatgFolderPath = FileLocations.Instance.DataDirectory;
            string[] WallPaperDirList = Directory.GetDirectories(AppDatgFolderPath);
            Image image;
            Stretch stretchType;

            for (int screenIndex = 0; screenIndex < controller.AllScreens.Count; screenIndex++)
            {
                FolderName = Path.Combine(AppDatgFolderPath , controller.AllScreens[screenIndex].UniqueDeviceID);

                /* 이미 만들어진 Folder가 있는가? */
                if( WallPaperDirList.Contains(FolderName) )
                {
                    StretchType = GetStretchType( FolderName );
                    ImageFilePath = GetWallpaperImageFileName( FolderName );

                    controller.AllScreens[screenIndex].ImageFilePath = ImageFilePath;
                    controller.AllScreens[screenIndex].StetchType = StretchType;

                    string[] SplitFilePath= ImageFilePath.Split('\\');
                    controller.AllScreens[screenIndex].OnlyFileName = SplitFilePath.Last();

#if TEST
                    image = LoadImageFromFile(controller.AllScreens[screenIndex].ImageFilePath);
#else
                    /* 이 방식으로 Image를 Load하면 Image 공유 문제를 해결 할 수 있다. */
                    using (FileStream fs = new FileStream(controller.AllScreens[screenIndex].ImageFilePath, FileMode.Open))
                    {
                        image = Image.FromStream(fs);
                        fs.Close();
                    }
#endif
                    stretchType = new Stretch(controller.AllScreens[screenIndex].StetchType);
                    
                    controller.SetActiveScreens(screenIndex);
                    controller.AddImage(image, stretchType.Type);
                }
            }
            
            image = null;
            stretchType = null;
            controller.ClearActiveScreen();
        }



        private string GetWallpaperImageFileName(string FolderName)
        {
            List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };
            string[] FileList = Directory.GetFiles(FolderName);

            foreach (string FileName in FileList)
            {
                if (ImageExtensions.Contains(Path.GetExtension(FileName).ToUpperInvariant()))
                {
                    return FileName;
                }
            }

            return "";
        }







        private string GetStretchType(string FolderName)
        {
            List<string> StretchTypes = new List<string>() { "StretchToFit", "OverStretch", "UnderStretch", "Center" };
            string[] FileList = Directory.GetFiles(FolderName);

            foreach(string FileName in FileList)
            {
                foreach(string Type in StretchTypes)
                {
                    if (FileName.Contains(Type))
                        return Type;                        
                }
            }

            return "";
        }








        private void InitUI()
        {
            /*  */
            Bitmap bmp = Properties.Resources.Manager_Form_Icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            /*  */
            this.BackColor = Color.FromArgb(255, 255, 255);

            FillFitCombo();
            CalcPreviewRect();
            CreateWallpaper();

            /* Font & Color 설정 */
            this.label_Wallpaper.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Bold(), 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Browse_Wallpaper.BackColor = Color.FromArgb(255, 255, 255);
            this.Label_Image_File_Path.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Choose_Fit.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.labelScreensSelected.BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelScreensSelected.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.TextBox_Image_File_Path.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFit.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label_Introduction.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreensSelected.ForeColor = Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));

            /*  */
            this.label_Introduction.Text = "This feature allows you to set\nan individual wallpaper for\neach display.\n\nFirst, select the display to change\nthe wallpaper and select a picture\nto set as the wallpaper.\n\nYou can also select the appropriate\n'Fit' to fit the screen.";

            /* 최초 실행시에는 Monitor가 선택된 상황이 아니므로, Disable한다. */
            EnableImageInputControl(false);
        }



        private void EnableImageInputControl(bool Enable)
        {
            TextBox_Image_File_Path.Enabled = Enable;
            Button_Browse_Wallpaper.Enabled = Enable;
            comboBoxFit.Enabled = Enable;
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



        private void CreateWallpaper()
        {
            if (Wallpaper != null)
            {
                Wallpaper.Dispose();
            }

            if (Wallpaper_Preview != null)
            {
                Wallpaper_Preview.Dispose();
            }

            Wallpaper = controller.CreateWallpaperImage(true);

            Wallpaper_Preview = controller.CreateWallpaperImage(false);

            /* 화면 저장 Test */
            //Wallpaper.Save("wallpaper.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Wallpaper_Preview.Save("wallpaper_preview.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
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



        /// <summary>
        /// Screen 번호와 Friendly Name을 출력
        /// </summary>
        /// 
        private void DisplaySelectedScreens(Rectangle previewScreen , Point Preview_PictureBox_Location)
        {
            Rectangle previewRect = new Rectangle(new Point(0, 0), new Size(previewScreen.Width , previewScreen.Height));
            
            Rectangle Selected_previewScreen = Controller.CalcDestRect(controller.DesktopRect, previewRect, controller.AllScreens[clickedScreenIndex].ScreenRect);

            string screenText = "";
            string FriendlyName = "";

            foreach (int screen in selectedScreens)
            {
                /* Friendly Name */
                FriendlyName = GetMonitorFriendlyName(Screen.AllScreens[screen]);

                if (screenText.Length > 0)
                {
                    screenText += ", ";
                }
                screenText += String.Format("{0} : {1}", screen + 1, FriendlyName);
            }

            /* Friendly Name */
            this.labelScreensSelected.Text = FriendlyName;

            this.labelScreensSelected.Location = new System.Drawing.Point(Preview_PictureBox_Location.X + Selected_previewScreen.X + (Selected_previewScreen.Width - this.labelScreensSelected.Width) / 2,
                                                                          Preview_PictureBox_Location.Y + previewScreen.Y + Selected_previewScreen.Height - (int)(this.labelScreensSelected.Height * 1.5));

        }



        /// <summary>
		/// 
		/// </summary>
        string GetMonitorFriendlyName(Screen selectedscreen)
        {
            foreach (DisplayDevice dd in allMonitorInfo)
            {
                if (dd.IsActive)
                {
                    if (dd.SourceName == selectedscreen.DeviceName)
                        return dd.FriendlyName;
                }
            }

            return "";
        }





        private void DisplayMonitor(Graphics g, Size previewSize, Rectangle screenRect, int screenIndex, string screenName)
        {
            int FONT_SIZE = 10;
            Rectangle previewRect = new Rectangle(new Point(0, 0), previewSize);

            // need to determine position of screen rect in the preview
            Rectangle previewScreen = Controller.CalcDestRect(controller.DesktopRect, previewRect, screenRect);

            Rectangle Center_Rect = new Rectangle(new Point(previewScreen.X + (previewScreen.Width - FONT_SIZE)/2,
                                                            previewScreen.Y + (previewScreen.Height - FONT_SIZE) /2),
                                                            new Size((int)(FONT_SIZE*1.5),(int)(FONT_SIZE*1.5)));

            // TODO: look into this!
            previewScreen = new Rectangle(previewScreen.Left, previewScreen.Top, previewScreen.Width - 1, previewScreen.Height - 1);            

            /*  */
            Pen Selected_Border = new Pen(Color.FromArgb((int)(0.24 * 0xFF), 202, 0, 76),5);
            Brush Selected_Screen = new SolidBrush(Color.FromArgb((int)(0.08 * 0xFF), 202, 0, 76));
            Brush Selected_No = new SolidBrush(Color.FromArgb((int)(0xFF), 0xCA, 0x00, 0x4C));

            Pen Non_Selected_Border = new Pen(Color.FromArgb((int)(0.08 * 0xFF), 1, 1, 1));
            Brush Non_Selected_Screen = new SolidBrush(Color.FromArgb((int)(0xFF), 0xE8 , 0xE8, 0xE8));
            Brush Non_Selected_No = new SolidBrush(Color.FromArgb((int)(0xFF), 0x86 , 0x86 , 0x86)); 

             /*  */
            Pen BorderPenColor = Non_Selected_Border;
            Brush TextColor = Non_Selected_No;
            Brush BackColor = Non_Selected_Screen;


            if (IsScreenSelected(screenIndex))
            {
                BorderPenColor = Selected_Border;
                TextColor = Selected_No;
                BackColor = Selected_Screen;
            }

            /* leave outermost pixels of image visible */
            previewScreen.Inflate(-1, -1);
            g.DrawRectangle(BorderPenColor, previewScreen);

            previewScreen.Inflate(-1, -1);

            /* 미리 보기 화면에서 이미 선택된 그림이 배경색으로 덮여버리는 문제 */
            //g.FillRectangle(BackColor, previewScreen);

            // display the screen name centered in the screen
            using (Font font = new Font(FontManager.LG_Smart_H_Bold(), FONT_SIZE, FontStyle.Bold, GraphicsUnit.Point))
            {
                g.DrawString(screenName, font, TextColor, Center_Rect);
            }


        }








        private void DisplayMonitors(Graphics g, Size previewSize)
        {
            for (int screenIndex = 0; screenIndex < controller.AllScreens.Count; screenIndex++)
            {
                string screenName = string.Format("{0}", screenIndex + 1);

                if (controller.AllScreens[screenIndex].Primary)
                {
                    //screenName += "P";
                }

                DisplayMonitor(g, previewSize, controller.AllScreens[screenIndex].ScreenRect, screenIndex, screenName);
            }
        }



        /// <summary>
		/// 현재 선택된 Screen의 Image File Path와 Stretch Type을 Update
		/// </summary>
        private void UpdateUIInfo()
        {
            TextBox_Image_File_Path.Text = controller.AllScreens[clickedScreenIndex].OnlyFileName;

            Stretch stretch = new Stretch(controller.AllScreens[clickedScreenIndex].StetchType);
            int idx = comboBoxFit.FindString(stretch.ToString());
            comboBoxFit.SelectedIndex = idx;
        }



        private void UpdatePreview()
        {
            /* Screen 번호와 Friendly Name을 출력 */
            DisplaySelectedScreens(previewRect , Preview_PictureBox.Location);

            /* 현재 선택된 Screen의 Image File Path와 Stretch Type을 Update */
            UpdateUIInfo();

            Image preview = new Bitmap(previewRect.Width, previewRect.Height);

            using (Graphics g = Graphics.FromImage(preview))
            {
                g.DrawImage(Wallpaper_Preview, 0, 0, preview.Width, preview.Height);

                // now indicate the positions of the monitors
                /* Preview Picture Box에 Screen 각 사각형을 그린다. */
                /* Selected Screen은 다른 색깔로 그린다. */
                DisplayMonitors(g, preview.Size);

            }

            // display preview
            if (Preview_PictureBox.Image != null)
            {
                Preview_PictureBox.Image.Dispose();
            }
            Preview_PictureBox.Image = preview;
        }





        private void OnSeclectedScreensChanged()
        {
            controller.SetActiveScreens(selectedScreens);

            CreateWallpaper();

            UpdatePreview();
        }



        private void AddSelectedScreen(int screenIndex)
        {
            if (!IsScreenSelected(screenIndex))
            {
                selectedScreens.Add(screenIndex);
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
                controller.AllScreens[clickedScreenIndex].ImageFilePath = dlg.FileName;

                /* 실제 출력은 FileName만 한다. */
                controller.AllScreens[clickedScreenIndex].OnlyFileName = dlg.SafeFileName;
                TextBox_Image_File_Path.Text = controller.AllScreens[clickedScreenIndex].OnlyFileName;

                try
                {
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

            image = Bitmap.FromFile(imageFilename);

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
            if (controller.AllScreens[clickedScreenIndex].ImageFilePath.Length > 0)
            {
                try
                {
                    //Image image = LoadImageFromFile(controller.AllScreens[clickedScreenIndex].ImageFilePath);
                    Image image;
                    using (FileStream fs = new FileStream(controller.AllScreens[clickedScreenIndex].ImageFilePath, FileMode.Open))
                    {
                        image = Image.FromStream(fs);
                        fs.Close();
                    }

                    Stretch stretchType = new Stretch(controller.AllScreens[clickedScreenIndex].StetchType);

                    //Debug.Assert(stretchType != null);
                    controller.AddImage(image, stretchType.Type);

                    CreateWallpaper();

                    UpdatePreview();

                    SetWallpaer();

                    /* 이전에 설정한 Wallpaper는 .bmp로 저장되어 있으니
                    처음 실행시에 보여줄 Wallpaper는 그 .bmp를 Load해서 보여주면 된다.*/
                    /* 설정한 Image File을 App. Folder에 복사한다.. 이 과정이 필요할까??? 
                    -> Current_Wallpaper.bmp를 Load해서 Preview화면에 보여주는 것은 내부 구조 활용에 더 복잡하게 만든다.
                    controller.AllScreens에 각각의 Monitor Unique ID로 저장된 Folder의 Image File을 활용해 최초 Preview화면 및 내부 구조 
                    활용이 더욱 효율적이다.                    */
                    SaveOriginalWallpaperImageFile();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.ApplicationName);
                }
            }
        }


        private void SaveOriginalWallpaperImageFile()
        {
            string WallpaperFolder , DestFilePath , StretchTypeFileName;
            string AppDatgFolderPath = FileLocations.Instance.DataDirectory;
            FileStream StretchTypeFile;

            for (int screenIndex = 0; screenIndex < controller.AllScreens.Count; screenIndex++)
            {
                if (controller.AllScreens[screenIndex].ImageFilePath.Length > 0)
                {
                    WallpaperFolder = Path.Combine(AppDatgFolderPath, controller.AllScreens[screenIndex].UniqueDeviceID);

                    /* Wallpaper로 사용된 원본 Image File을 Monitor Unique값으로 만든 Folder에 복사해 놓는다. */
                    DestFilePath = Path.Combine(WallpaperFolder, controller.AllScreens[screenIndex].OnlyFileName);

                    if (Directory.Exists(WallpaperFolder) == true)
                        DeleteStretchTypeFileOnly(WallpaperFolder);

                    if (string.Compare(DestFilePath, controller.AllScreens[screenIndex].ImageFilePath) != 0)
                    {
                        /* Folder가 없으면 우선 만든다. */
                        if (Directory.Exists(WallpaperFolder) == false)
                        {
                            Directory.CreateDirectory(WallpaperFolder);
                        }
                        /*  Folder가 있으면 그 안의 File들은 이전 Wallpaper들 정보들이기 때문에 모두 지운다. */
                        else
                        {
                            DeleteAllFilesInFolder(WallpaperFolder);
                        }

                        File.Copy(controller.AllScreens[screenIndex].ImageFilePath, DestFilePath, true);
                    }

                    StretchTypeFileName = Path.Combine(WallpaperFolder, controller.AllScreens[screenIndex].StetchType);
                    StretchTypeFile = File.Create(StretchTypeFileName);
                    StretchTypeFile.Close();
                }

            }


        }


        private void DeleteAllFilesInFolder(string Path)
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
        }

        private void DeleteStretchTypeFileOnly(string Path)
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                if(file.Extension == "")
                    file.Delete();
            }
        }



#if TEST
        private void Set_Wallpaper_Click(object sender, EventArgs e)
        {
            ILocalEnvironment localEnvironment = new LocalEnvironment();
            WindowsWallpaper windowsWallpaper = new WindowsWallpaper(localEnvironment, wallpaper, controller.DesktopRect);
            windowsWallpaper.SetWallpaper(false);
        }
#endif
        private void SetWallpaer()
        {
            ILocalEnvironment localEnvironment = new LocalEnvironment();
            WindowsWallpaper windowsWallpaper = new WindowsWallpaper(localEnvironment, Wallpaper, controller.DesktopRect);            
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
            /* check if the area clicked belongs to one of the screens */
            /* Click한 위치가 몇 번 Screen에 해당하는지 확인 */
            clickedScreenIndex = PosnToScreen(e.X, e.Y);

            if (clickedScreenIndex >= 0)
            {
#if SUPPORT_MULTIFUL_SCREEN_SELECTION
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
#endif
                {
                    /* Monitor를 선택한 경우 */
                    selectedScreens.Clear();
                    AddSelectedScreen(clickedScreenIndex);
                    EnableImageInputControl(true);
                }
            }
        }





        private void ChangedStretchMode(object sender, EventArgs e)
        {

            if (comboBoxFit.SelectedIndex >= 0)
            {
                Stretch stretchType = comboBoxFit.SelectedItem as Stretch;
                controller.AllScreens[clickedScreenIndex].StetchType = stretchType.ToString(true);

                if( controller.ActiveScreensCount() > 0 )
                    ApplyImage();
            }
        }

        private void TextBox_Image_File_Path_Enter(object sender, EventArgs e)
        {
            TextBox_Image_File_Path.Enabled = false;
            TextBox_Image_File_Path.Enabled = true;
        }
    }
}
