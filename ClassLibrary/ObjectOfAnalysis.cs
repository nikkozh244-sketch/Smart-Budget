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
        internal DateTime _date;
        internal string _comment;

        public int Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        public string TypeOfOperation
        {
            get { return _typeOfOperation; }
            set { _typeOfOperation = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public ObjectOfAnalysis(int sum, string typeOfOperation, string category, DateTime date, string comment)
        {
            Sum = sum;
            TypeOfOperation = typeOfOperation;
            Category = category;
            Date = date;
            Comment = comment;
        }

        public ObjectOfAnalysis()
        {
            Sum = 0;
            TypeOfOperation = "";
            Category = "";
            Date = DateTime.Now;
            Comment = "";
        }

        public void Init(int sum, string typeOfOperation, string category, DateTime date, string comment)
        {
            Sum = sum;
            TypeOfOperation = typeOfOperation;
            Category = category;
            Date = date;
            Comment = comment;
        }

        public void ImportInit(object[]importData)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Изменяет свойства анализируемого объекта 
        /// </summary>
        /// <param name="other"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void ChangeObject(ObjectOfAnalysis other)
        {
            if (other.TypeOfOperation != null || other.Category != null || other.Comment != null)
            {
                this.Sum = other.Sum;
                this.TypeOfOperation = other.TypeOfOperation;
                this.Category = other.Category;
                this.Date = other.Date;
                this.Comment = other.Comment;
            }
            else
                throw new Exception("Ошибка! Не забудьте ввести все параметры");
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }

        //Использование интерфейса IFormattable
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public virtual string Show()
        {
            throw new NotImplementedException();
        }
    }
}
