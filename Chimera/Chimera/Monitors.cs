using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public class Monitors : List<Monitor>
    {
        public Monitors(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        /// Gets the bounds rectangle for the union of all monitors
        /// </summary>
        public Rectangle Bounds
        {
            get
            {
                Rectangle boundingRect = Rectangle.Empty;

                for (int monitorIndex = 0; monitorIndex < this.Count; monitorIndex++)
                {
                    if (monitorIndex == 0)
                    {
                        boundingRect = this[monitorIndex].Bounds;
                    }
                    else
                    {
                        boundingRect = Rectangle.Union(boundingRect, this[monitorIndex].Bounds);
                    }
                }

                return boundingRect;
            }
        }

        /// <summary>
        /// Gets the working area rectangle for the union of all monitors
        /// </summary>
        public Rectangle WorkingArea
        {
            get
            {
                Rectangle boundingRect = Rectangle.Empty;

                for (int monitorIndex = 0; monitorIndex < this.Count; monitorIndex++)
                {
                    if (monitorIndex == 0)
                    {
                        boundingRect = this[monitorIndex].WorkingArea;
                    }
                    else
                    {
                        boundingRect = Rectangle.Union(boundingRect, this[monitorIndex].WorkingArea);
                    }
                }

                return boundingRect;
            }
        }

        public int FindMonitorIndex(Monitor monitor)
        {
            int monitorIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                // We cannnot compare the screen objects as Screen.FromRectangle()
                // creates a new instance of the screen, rather than returning the
                // one in the AllScreens array.
                // Also comparing the DeviceName does not always seem to work,
                // as have seen corrupt names (on XP SP3 with Catalyst 9.1).
                // So we just compare the Bounds rectangle.
                if (monitor.Bounds == base[i].Bounds)
                {
                    monitorIndex = i;
                    break;
                }
            }

            return monitorIndex;
        }

        public Monitor FromRectangle(Rectangle rect)
        {
            int monitorIndex = MonitorIndexFromRectangle(rect);

            if (monitorIndex < 0 || monitorIndex >= Count)
            {
                // shouldn't happen
                throw new ApplicationException(string.Format("Monitors.FromRectangle({0}): Could not find monitor", rect));
            }

            return base[monitorIndex];
        }

        public Monitor FromPoint(Point point)
        {
            Screen screen = Screen.FromPoint(point);
            return MonitorFromScreen(screen);
        }

        public int MonitorIndexFromRectangle(Rectangle rect)
        {
            // we could work this out ourselve,
            // but let's use Screen to do the work
            Screen screen = Screen.FromRectangle(rect);

            return MonitorIndexFromScreen(screen);
        }

        public int MonitorIndexFromPoint(Point point)
        {
            // we could work this out ourselve,
            // but let's use Screen to do the work
            Screen screen = Screen.FromPoint(point);

            return MonitorIndexFromScreen(screen);
        }

        public Monitor PrimaryMonitor
        {
            get
            {
                return MonitorFromScreen(Screen.PrimaryScreen);
            }
        }

        Monitor MonitorFromScreen(Screen screen)
        {
            int monitorIndex = MonitorIndexFromScreen(screen);

            if (monitorIndex < 0 || monitorIndex >= Count)
            {
                // shouldn't happen
                return null;
            }

            return base[monitorIndex];
        }

        int MonitorIndexFromScreen(Screen screen)
        {
            for (int i = 0; i < Count; i++)
            {
                if (screen.Bounds == base[i].Bounds)
                {
                    return i;
                }
            }

            // shouldn't happen
            return -1;
        }
    }
}
