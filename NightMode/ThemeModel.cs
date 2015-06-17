using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NightMode
{
    public class ThemeModel : INotifyPropertyChanged
    {
        private string _themeName;
        private string _backgroundColour;
        private string _foregroundColour;
        private string _headerColour;

        public string ThemeName
        {
            get { return _themeName; }
            set { _themeName = value; OnPropertyChanged("ThemeName"); }
        }

        public string BackgroundColour
        {
            get { return _backgroundColour; }
            set { _backgroundColour = value; OnPropertyChanged("BackgroundColour"); }
        }

        public string ForegroundColour
        {
            get { return _foregroundColour; }
            set { _foregroundColour = value; OnPropertyChanged("ForegroundColour"); }
        }

        public string HeaderColour
        {
            get { return _headerColour; }
            set { _headerColour = value; OnPropertyChanged("HeaderColour"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
