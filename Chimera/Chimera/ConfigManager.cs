using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Chimera.Resources;
using System.IO;



namespace Chimera
{  


    public class ConfigManager
    {
        Configuration applicationConfig;
        string configPathAndName;
        ConfigValues configValues;


        public ConfigManager(ConfigValues cv )
        {
            configPathAndName = GetConfigFilePath();
            applicationConfig = OpenConfiguration(configPathAndName);
            configValues = cv;

            /**/
            VerifyConfigValues();
        }


        /*  */
        private void VerifyConfigValues()
        {


            /* Enable Cursor Feature  */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains( Properties.Resources.ConfigItem_EnableCursorFeature ) )
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.EnableCursorFeature = string.Equals("false",
                                                                 applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableCursorFeature].Value)
                                                                 ? false : true;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableCursorFeature, "false");
                configValues.EnableCursorFeature = false;
            }


            /* Enable Move Cursor Next Screen */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_EnableMoveCursorNextScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.EnableMoveCursorNextScreen = string.Equals("false",
                                                                 applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorNextScreen].Value)
                                                                 ? false : true;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableMoveCursorNextScreen, "false");
                configValues.EnableMoveCursorNextScreen = false;
            }


            /* Hotkey Move Cursor Next Screen  */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.HotkeyMoveCursorNextScreen = applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen].Value;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen, "Not Defined");
                configValues.HotkeyMoveCursorNextScreen = "Not Defined";
            }


            /* Enable Move Cursor Prev Screen */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.EnableMoveCursorPrevScreen = string.Equals("false",
                                                                 applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen].Value)
                                                                 ? false : true;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen, "false");
                configValues.EnableMoveCursorPrevScreen = false;
            }


            /* Hotkey Move Cursor Prev Screen */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.HotkeyMoveCursorPrevScreen = applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen].Value;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen, "Not Defined");
                configValues.HotkeyMoveCursorPrevScreen = "Not Defined";
            }


            /* Enable Lock Cursor To Screen */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_EnableLockCursorToScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.EnableLockCursorToScreen = string.Equals("false",
                                                                 applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableLockCursorToScreen].Value)
                                                                 ? false : true;

            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableLockCursorToScreen, "false");
                configValues.EnableLockCursorToScreen = false;
            }


            /* Hotkey Lock Cursor To Screen */
            if (applicationConfig.AppSettings.Settings.AllKeys.Contains(Properties.Resources.ConfigItem_HotkeyLockCursorToScreen))
            {
                /* 값이 있는 경우, 값을 읽어온다. */
                configValues.HotkeyLockCursorToScreen = applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyLockCursorToScreen].Value;
            }
            else
            {
                /* 값이 없으면 Default값으로 기록한다. */
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyLockCursorToScreen, "Not Defined");
                configValues.HotkeyLockCursorToScreen = "Not Defined";
            }

            /*  */
            applicationConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(applicationConfig.AppSettings.SectionInformation.Name);
        }



        /// <summary>
        /// ConfigValues 를 받아서 해당 내용을 설정 File에 저장합니다.
        /// </summary>        
        /// <param name="ConfigValues ">저장할 ConfigValues </param>
        public void SaveConfigValuesToFile(ConfigValues cv)
        {
            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableCursorFeature] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableCursorFeature, cv.EnableCursorFeature ? "true" : "false");
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableCursorFeature].Value = cv.EnableCursorFeature ? "true" : "false";


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorNextScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableMoveCursorNextScreen, cv.EnableMoveCursorNextScreen ? "true" : "false");
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorNextScreen].Value = cv.EnableMoveCursorNextScreen ? "true" : "false";


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen, cv.HotkeyMoveCursorNextScreen);
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorNextScreen].Value = cv.HotkeyMoveCursorNextScreen;


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen, cv.EnableMoveCursorPrevScreen ? "true" : "false");
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableMoveCursorPrevScreen].Value = cv.EnableMoveCursorPrevScreen ? "true" : "false";


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen, cv.HotkeyMoveCursorPrevScreen);
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyMoveCursorPrevScreen].Value = cv.HotkeyMoveCursorPrevScreen;


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableLockCursorToScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_EnableLockCursorToScreen, cv.EnableLockCursorToScreen ? "true" : "false");
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_EnableLockCursorToScreen].Value = cv.EnableLockCursorToScreen ? "true" : "false";


            if (applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyLockCursorToScreen] == null)
                applicationConfig.AppSettings.Settings.Add(Properties.Resources.ConfigItem_HotkeyLockCursorToScreen, cv.HotkeyLockCursorToScreen);
            else
                applicationConfig.AppSettings.Settings[Properties.Resources.ConfigItem_HotkeyLockCursorToScreen].Value = cv.HotkeyLockCursorToScreen;

            applicationConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(applicationConfig.AppSettings.SectionInformation.Name);
        }






        /*  */
        private string GetConfigFilePath()
        {
            string projectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            string projectVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string configPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), projectName, projectVersion);
            string configPathAndName = System.IO.Path.Combine(configPath, projectName + ".config");

            return configPathAndName;
        }





        /* 설정 파일 열기 */
        private Configuration OpenConfiguration(string configFile)
        {
            Configuration config = null;

            if (String.IsNullOrWhiteSpace(configFile))
            {
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            }
            else
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = configFile;
                config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            }

            return config;
        }




        /* 설정 추가하기 */
        public void AddConfigItem(string key, string val, string configFile)
        {
            try
            {
                Configuration config = this.OpenConfiguration(configFile);

                if (config.AppSettings.Settings.AllKeys.Contains(key))
                {
                    config.AppSettings.Settings[key].Value = val;
                }
                else
                {
                    config.AppSettings.Settings.Add(key, val);
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Properties.Resources.ApplicationName);
            }
        }


        /*  */
        public void AddConfigItem(string key, string val)
        {
            AddConfigItem(key, val, configPathAndName);
        }


        /* 설정 가져오기 */
        public string GetConfigItem(string key, string configFile)
        {
            Configuration config = this.OpenConfiguration(configFile);
            string val = String.Empty;

            if (config.AppSettings.Settings.AllKeys.Contains(key))
            {
                val = config.AppSettings.Settings[key].Value;
            }

            return val;
        }




        /*  */
        public string GetConfigItem(string key)
        {
            return GetConfigItem(key, configPathAndName);
        }





        /* 설정 삭제하기 */
        public void RemoveConfigItem(string key, string configFile)
        {
            Configuration config = this.OpenConfiguration(configFile);

            if (config.AppSettings.Settings.AllKeys.Contains(key))
            {
                config.AppSettings.Settings.Remove(key);

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
        }


        /*  */
        public void RemoveConfigItem(string key)
        {
            RemoveConfigItem(key, configPathAndName);
        }

    }
}
