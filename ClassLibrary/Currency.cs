using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class Currency
    {
        public float _amount; //Определяет размер операции - float, так как сумма не обязана быть целочисленной

        //Свойство класса
        public float Amount
        { 
            get { return _amount; } 
            set 
            {
                //Проверка того, что после запятой не более двух знаков
                string tempAmount = _amount.ToString();
                int indexOfComa = tempAmount.IndexOf(",");
                int amountLength = tempAmount.Length;

                if (amountLength - indexOfComa > 2)
                    throw new Exception("Ошибка! Вводите сумму операции с не более чем двумя знаками после запятой!");
                _amount = value; 
            } 
        }

        //Метод для ввода размера операции
        public void Init()
        {
            if (float.TryParse(Console.ReadLine(), out float tempAmount))
                Amount = tempAmount;
            else
                throw new Exception("Ошибка! Значение введено некорректно");
        }

        //Конструктор без параметров
        public Currency()
        {
            Amount = 0;
        }

        //Конструктор с параметром для рублей
        public Currency(float amount)
        {
            Amount = amount;
        }

        //Конструктор с параметром для долларов
        public Currency(float amount, SettingsService settings)
        {
            Amount = amount * settings.DollarValue;
        }

        //Перегрузка метода ToString
        public virtual string ToString()
        {
            return $"{_amount}";
        }
    }
}
