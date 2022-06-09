﻿using System;
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



        public ConfigManager()
        {
            configPathAndName = GetConfigFilePath();
            applicationConfig = OpenConfiguration(configPathAndName);
            SetAppConfig("CurNextScreen", "123456");
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
        public void SetAppConfig(string key, string val, string configFile)
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
        public void SetAppConfig(string key, string val)
        {
            SetAppConfig(key, val, configPathAndName);
        }


        /* 설정 가져오기 */
        public string GetAppConfig(string key, string configFile)
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
        public string GetAppConfig(string key)
        {
            return GetAppConfig(key, configPathAndName);
        }



        /* 설정 삭제하기 */
        public void RemoveAppConfig(string key, string configFile)
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
        public void RemoveAppConfig(string key)
        {
            RemoveAppConfig(key, configPathAndName);
        }

    }
}
