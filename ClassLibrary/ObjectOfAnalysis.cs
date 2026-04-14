using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary 
{
    internal class ObjectOfAnalysis : IFormattable
    {
        internal int _sum;
        internal string _typeOfOperation;
        internal string _category;



        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
