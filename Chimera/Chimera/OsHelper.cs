using System;
using System.Collections.Generic;
using System.Text;

namespace Chimera
{
    /// <summary>
    /// Utility class to handle O/S specific issues
    /// </summary>
    class OsHelper
    {
        /// <summary>
        /// Determine if we are running Windows 7 or later
        /// </summary>
        /// <returns>true if this is Windows 7 or later</returns>
        public static bool IsWin7OrLater()
        {
            bool isWin7orLater = false;

            System.OperatingSystem osInfo = System.Environment.OSVersion;

            if (osInfo.Platform == PlatformID.Win32NT)
            {
                // 5.0 => 2000
                // 5.1 => XP
                // 5.2 => 2003
                // 6.0 => Vista / 2008
                // 6.1 => Win 7 / 2008 R2 / 2011
                // 6.2 => Win 8 / 2012
                if (osInfo.Version.Major == 6)
                {
                    if (osInfo.Version.Minor >= 1)
                    {
                        isWin7orLater = true;
                    }
                    // TODO: what about future versions of Windows?
                }
                else if (osInfo.Version.Major > 6)
                {
                    isWin7orLater = true;
                }

            }

            return isWin7orLater;
        }
    }
}
