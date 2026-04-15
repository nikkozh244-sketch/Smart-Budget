using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class SettingsService
    {
        public string _language; //Определяет язык приложения
        public bool _isDark; //Определяет, включена ли темная тема приложения
        public bool _isLeftHanded; //Определяет, включен ли "Режим левши"
        public bool _isDogTheme; //Определяет, включен ли "Режим собачника"
        // РЕШИТЬ С ВАЛЮТОЙ

        // Свойства класса
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

        //Конструктор с параметрами
        public SettingsService(string language, bool isDark, bool isLeftHanded, bool isDogTheme)
        {
            Language = language;
            IsDark = isDark;
            IsLeftHanded = isLeftHanded;
            IsDogTheme = isDogTheme;            
        }

        //Конструктор без параметров - при первом запуске создается объект с именно такими свойствами
        public SettingsService()
        {
            Language = "Русский";
            IsDark = false;
            IsLeftHanded = false;
            IsDogTheme = false;
        }

        //Здесь необходимо реализовать метод, загружающий из файла объект с сохраненными свойствами
        //Это делается для того, чтобы пользователь мог не менять настройки под себя каждый раз, когда выходит из приложения и заходит обратно
        public SettingsService LoadSettings()
        {
            throw new NotImplementedException();
        }

        //Здесь необходимо реализовать метод, сохраняющий на устройство файл с объектом со свойствами, которые задал пользователь
        public void SaveSettings()
        {
            throw new NotImplementedException();
        }

        //Здесь необходимо реализовать метод, позволяющий сбрасывать настройки до начальных
        public SettingsService ResetSettigs()
        {
            throw new NotImplementedException();
        }
               
    }
}
