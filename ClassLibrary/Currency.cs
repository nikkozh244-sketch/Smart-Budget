using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class Currency
    {
        public float _amount;

        public float Amount
        { 
            get { return _amount; } 
            set 
            {
                string tempAmount = _amount.ToString();
                int indexOfComa = tempAmount.IndexOf(",");
                int amountLength = tempAmount.Length;

                if (amountLength - indexOfComa > 2)
                    throw new Exception("Ошибка! Вводите сумму операции с не более чем двумя знаками после запятой!");
                _amount = value; 
            } 
        }

        public void Init()
        {
            if (float.TryParse(Console.ReadLine(), out float tempAmount))
                Amount = tempAmount;
            else
                throw new Exception("Ошибка! Значение введено некорректно");
        }

        public Currency()
        {
            Amount = 0;
        }

        public Currency(float amount)
        {
            Amount = amount;
        }

        public virtual string ToString()
        {
            return $"{_amount}";
        }
    }
}
