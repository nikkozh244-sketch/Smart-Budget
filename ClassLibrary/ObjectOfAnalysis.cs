using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary 
{
    internal class ObjectOfAnalysis : IFormattable
    {
        internal int _sum; //Определяет сумму операции
        internal string _typeOfOperation; //Определяет тип операции
        internal string _category; //Определяет категорию операции


        //Использование интерфейса IFormattable
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
