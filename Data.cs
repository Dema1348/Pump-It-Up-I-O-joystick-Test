using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piu__Input_Test
{
    class Data
    {
        private string upLeft;
        private string upRight;
        private string center;
        private string downLeft;
        private string downRight;

        public Data() {
            upLeft = System.Configuration.ConfigurationManager.AppSettings["UpLeft"];
            upRight = System.Configuration.ConfigurationManager.AppSettings["UpRight"];
            center = System.Configuration.ConfigurationManager.AppSettings["Center"];
            downLeft = System.Configuration.ConfigurationManager.AppSettings["DownLeft"];
            downRight = System.Configuration.ConfigurationManager.AppSettings["DownRight"];
        }

        public string UpLeft
        {
            get
            {
                return upLeft;
            }

            set
            {
                upLeft = value;
            }
        }

        public string UpRight
        {
            get
            {
                return upRight;
            }

            set
            {
                upRight = value;
            }
        }

        public string Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public string DownLeft
        {
            get
            {
                return downLeft;
            }

            set
            {
                downLeft = value;
            }
        }

        public string DownRight
        {
            get
            {
                return downRight;
            }

            set
            {
                downRight = value;
            }
        }


        public static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        public override string ToString() {
            return   upLeft+upRight+ center+ downLeft+ downRight;
    }
    }
}
