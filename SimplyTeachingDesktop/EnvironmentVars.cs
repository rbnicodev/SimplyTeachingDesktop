using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    public class EnvironmentVars
    {
        public static Boolean night = true;
        public static Color color1 = Color.White;
        public static Color color2 = Color.FromArgb(255, 84, 84, 84);
        public static Color color3 = Color.FromArgb(255, 74, 74, 74);
        public static Color color4 = Color.FromArgb(255, 64, 64, 64);
        public static Color color5 = Color.FromArgb(255, 54, 54, 54);
        public static Color color6 = Color.FromArgb(255, 44, 44, 44);
        public static Color color7 = Color.FromArgb(255, 0, 0, 0);
        public static Color colorResaltHigh = Color.FromArgb(255, 0, 140, 225);
        public static Color colorResalt = Color.FromArgb(255, 0, 120, 215);
        public static Color colorResaltLow = Color.FromArgb(255, 0, 100, 195);

        public static string UrlConnection = "datasource=localhost;port=3306;username=root;password=bitnami;database=SimplyTeaching;";
        public static string UrlConnection = "datasource=sql11.freemysqlhosting.net;port=3306;username=sql11470340;password=TF2jhuIMjf;database=sql11470340;";


        public static void SetNight(Boolean activeNight)
        {
            if(activeNight)
            {
                color1 = Color.White;
                color2 = Color.FromArgb(255, 84, 84, 84);
                color3 = Color.FromArgb(255, 74, 74, 74);
                color4 = Color.FromArgb(255, 64, 64, 64);
                color5 = Color.FromArgb(255, 54, 54, 54);
                color6 = Color.FromArgb(255, 44, 44, 44);
                color7 = Color.Black;
                night = true;
    }
            else
            {
                color7 = Color.White;
                color6 = Color.FromArgb(255, 245, 245, 245);
                color5 = Color.FromArgb(255, 230, 230, 230);
                color4 = Color.FromArgb(255, 220, 220, 220);
                color3 = Color.FromArgb(255, 210, 210, 210);
                color2 = Color.FromArgb(255, 200, 200, 200);
                color1 = Color.Black;
                night = false;
            }
        }
    
    }

}
