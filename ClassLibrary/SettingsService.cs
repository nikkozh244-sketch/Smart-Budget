using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class SettingsService
    {
        public string _language;
        public bool _isDark;
        public bool _isLeftHanded;
        public bool _isDogTheme;
        // РЕШИТЬ С ВАЛЮТОЙ

        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
            }
        }

        public bool IsDark
        {
            get { return _isDark; }
            set
            {
                _isDark = value;
            }
        }

        public bool IsLeftHanded
        {
            get { return _isLeftHanded; }
            set
            {
                _isLeftHanded = value;
            }
        }
        public bool IsDogTheme
        {
            get { return _isDogTheme; }
            set
            {
                _isDogTheme = value;
            }
        }

        public SettingsService(string language, bool isDark, bool isLeftHanded, bool isDogTheme)
        {
            Language = language;
            IsDark = isDark;
            IsLeftHanded = isLeftHanded;
            IsDogTheme = isDogTheme;            
        }

        public SettingsService()
        {
            Language = "Русский";
            IsDark = false;
            IsLeftHanded = false;
            IsDogTheme = false;
        }

        public SettingsService LoadSettings()
        {
            throw new NotImplementedException();
        }

        public void SaveSettings()
        {
            throw new NotImplementedException();
        }

        public SettingsService ResetSettigs()
        {
            throw new NotImplementedException();
        }
               
    }
}
