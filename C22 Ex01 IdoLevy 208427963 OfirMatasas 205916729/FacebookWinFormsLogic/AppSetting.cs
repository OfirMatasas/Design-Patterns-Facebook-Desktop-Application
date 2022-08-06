using System.IO;
using System.Xml.Serialization;

namespace FacebookWinFormsLogic
{
    public class AppSetting
    {
        private const string k_XmlFileName = "AppSetting.xml";
        public bool RememberUserInfo { get; private set; }
        public string LastAccessToken { get; private set; }

        private AppSetting()
        {
            RememberUserInfo = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(k_XmlFileName, File.Exists(k_XmlFileName) ? FileMode.Truncate : FileMode.CreateNew))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSetting LoadFromFile()
        {
            AppSetting appSetting = null;
            XmlSerializer deserializer;

            if (File.Exists(k_XmlFileName))
            {
                using (Stream stream = new FileStream(k_XmlFileName, FileMode.Open))
                {
                    deserializer = new XmlSerializer(typeof(AppSetting));
                    appSetting = deserializer.Deserialize(stream) as AppSetting;
                }
            }
            else
            {
                appSetting = new AppSetting();
            }

            return appSetting;
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
