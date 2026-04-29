using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary 
{
    internal class ObjectOfAnalysis : IFormattable
    {
        // Поля класса
        internal int _sum; //Определяет сумму операции
        internal string _typeOfOperation; //Определяет тип операции
        internal string _category; //Определяет категорию операции
        internal DateTime _date; //Определяет дату операции
        internal string _comment; //Определяет комментарий по операции (уточнить бы)

        // Свойства класса
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

        // Конструктор без параметров
        public ObjectOfAnalysis()
        {
            Sum = 0;
            TypeOfOperation = "";
            Category = "";
            Date = DateTime.Now;
            Comment = "";
        }

        // Конструктор с параметрами
        public ObjectOfAnalysis(int sum, string typeOfOperation, string category, DateTime date, string comment)
        {
            Sum = sum;
            TypeOfOperation = typeOfOperation;
            Category = category;
            Date = date;
            Comment = comment;
        }

        /// <summary>
        ///Метод по вводу данных (ПЕРЕДЕЛАТЬ!!!) 
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="typeOfOperation"></param>
        /// <param name="category"></param>
        /// <param name="date"></param>
        /// <param name="comment"></param>
        public void Init(int sum, string typeOfOperation, string category, DateTime date, string comment)
        {
            Sum = sum;
            TypeOfOperation = typeOfOperation;
            Category = category;
            Date = date;
            Comment = comment;
        }

        /// <summary>
        ///Метод по импорту данных 
        /// </summary>
        /// <param name="importData"></param>
        /// <exception cref="NotImplementedException"></exception>
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

        /// <summary>
        ///Перегрузка метода ToString
        /// </summary>
        /// <returns></returns>
        public virtual string ToString()
        {
            return $"{this.Sum} {this.TypeOfOperation} {this.Category} {this.Date} {this.Comment}";
        }

        /// <summary>
        /// Использование интерфейса IFormattable
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода объекта
        /// </summary>
        /// <returns></returns>
        public string Show()
        {
            return $"Сумма: {this.Sum}, Тип операции: {this.TypeOfOperation}, Категория: {this.Category}, Дата: {this.Date}, Комментарий: {this.Comment}"; ;
        }
    }
}
