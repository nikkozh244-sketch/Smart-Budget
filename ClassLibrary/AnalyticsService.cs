using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBudget.ClassLibrary
{
    internal class AnalyticsService : BudgetService
    {
        //Метод для определения итоговых трат
        public float TotalIncome()
        {
            throw new NotImplementedException();
        }

        //Метод для определения итоговых доходов
        public float TotalConsumption()
        {
            throw new NotImplementedException();
        }

        //Метод для поиска самой популярной категории трат
        public string FindMostPopularConsumptionCategory()
        {
            throw new NotImplementedException();
        }

        //Метод для поиска самой популярной категории доходов (под вопросом необходимости)
        public string FindMostPopularIncomeCategory()
        {
            throw new NotImplementedException();
        }

        //Метод для поиска текущего баланса
        public float FindBalance()
        {
            throw new NotImplementedException();
        }

        //Метод для вывода совета по итогам трат
        public string ShowAdviceByConsumption()
        {
            throw new NotImplementedException();
        }

        //Метод для вывода совета по категории
        public string ShowAdviceByCategories()
        {
            throw new NotImplementedException();
        }
    }
}
