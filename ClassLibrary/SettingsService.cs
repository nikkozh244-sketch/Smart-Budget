using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class SettingsService
    {
        // Поля класса
        protected string _language; //Определяет язык приложения
        protected bool _isDark; //Определяет, включена ли темная тема приложения
        protected bool _isLeftHanded; //Определяет, включен ли "Режим левши"
        protected bool _isDogTheme; //Определяет, включен ли "Режим собачника"
        protected int _dollarValue; //Определяет курс доллара

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

        public int DollarValue
        {
            get { return _dollarValue; }
            set
            {
                if (value < 0)
                    throw new Exception("Ошибка! Курс доллара не может быть отрицательным");
                if (value == 0)
                    throw new Exception("Ошибка! Курс доллара не может равняться нулю");
                if (value > 121) //Исторический максимум - обговорить с бригадой, а надо ли это чудо вообще
                    throw new Exception("Ошибка! Курс доллара превышает исторический максимум! Неужто новая острая ситуация в мире?");
                _dollarValue = value;
            }
        }

        //Конструктор без параметров - при первом запуске создается объект с именно такими свойствами
        public SettingsService()
        {
            Language = "Русский";
            IsDark = false;
            IsLeftHanded = false;
            IsDogTheme = false;
            DollarValue = 1;
        }

        //Конструктор с параметрами
        public SettingsService(string language, bool isDark, bool isLeftHanded, bool isDogTheme, int dollarValue)
        {
            Language = language;
            IsDark = isDark;
            IsLeftHanded = isLeftHanded;
            IsDogTheme = isDogTheme;
            DollarValue = dollarValue;
        }

        /// <summary>
        ///Метод для выгрузки настроек из файла (требует дополнений точно) 
        /// </summary>
        /// <returns></returns>
        static public SettingsService LoadSettings()
        {
            string serilizedSettings = File.ReadAllText(null);

            SettingsService settings = JsonConvert.DeserializeObject<SettingsService>(serilizedSettings);

            return settings;
        }

        /// <summary>
        ///Метод по сохранению настроек в текстовый файл (тоже требует дополнений, когда разберемся с экзешником)
        /// </summary>
        /// <param name="settings">Настройки</param>
        static public void SaveSettings(SettingsService settings)
        {
            string serializedSettings = JsonConvert.SerializeObject(settings);

            File.WriteAllText(null, serializedSettings);
        }

        /// <summary>
        ///Метод, позволяющий сбросить настройки до тех, что стоят по умолчанию 
        /// </summary>
        public void ResetSettings()
        {
            this.Language = "Русский";
            this.IsDark = false;
            this.IsLeftHanded = false;
            this.IsDogTheme = false;
            this.DollarValue = 1;
        }
    }
}
