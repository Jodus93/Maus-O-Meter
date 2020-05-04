using System;
using System.Configuration;



namespace Mausometer
{
    class IO {

      
  

        public IO()
        {
          

           }

        public string load(string key)
        {
           try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key];
                return result;
            }
            catch
            {
                return "0";
            }

        }

      




        public void save(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configFile.AppSettings.Settings;
            try
            {
                
                appSettings[key].Value = value;
                configFile.Save();
               
            }
            catch
            {
               
            }

        }



    }
}
