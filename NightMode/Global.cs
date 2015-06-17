using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightMode
{
    public static class Global
    {

        private static ThemeModel themeModel;

        public static ThemeModel ThemeModel
        {
            get { return themeModel; }
            set { themeModel = value; }
        }

        public static void LightTheme()
        {
            ThemeModel.ThemeName = "Light";
            ThemeModel.BackgroundColour = "#EEEEEE";
            ThemeModel.HeaderColour = "#BBBBBB";
            ThemeModel.ForegroundColour = "#000000";
        }

        public static void DarkTheme()
        {
            ThemeModel.ThemeName = "Dark";
            ThemeModel.BackgroundColour = "#333333";
            ThemeModel.HeaderColour = "#000000";
            ThemeModel.ForegroundColour = "#FFFFFF";
        }

    }
}
