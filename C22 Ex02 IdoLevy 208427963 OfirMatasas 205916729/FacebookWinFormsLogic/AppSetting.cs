﻿using System.IO;
using System.Xml.Serialization;

namespace FacebookWinFormsLogic
{
    public class AppSetting
    {
        private const string k_XMLFileName = "AppSetting.xml";

        public bool RememberUserInfo { get; set; }

        public string LastAccessToken { get; set; }

        private AppSetting()
        {
            RememberUserInfo = false;
            LastAccessToken = null;
        }

        public static AppSetting LoadFromFile()
        {
            AppSetting appSetting;
            XmlSerializer serializer;

            if (File.Exists(k_XMLFileName))
            {
                using (Stream stream = new FileStream(k_XMLFileName, FileMode.Open))
                {
                    serializer = new XmlSerializer(typeof(AppSetting));
                    appSetting = serializer.Deserialize(stream) as AppSetting;
                }
            }
            else
            {
                appSetting = new AppSetting();
            }

            return appSetting;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(k_XMLFileName, File.Exists(k_XMLFileName) ? FileMode.Truncate : FileMode.CreateNew))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public void RememberUser(string i_AccessToken)
        {
            RememberUserInfo = true;
            LastAccessToken = i_AccessToken;
        }

        public void ForgetUser()
        {
            RememberUserInfo = false;
            LastAccessToken = null;
        }
    }
}