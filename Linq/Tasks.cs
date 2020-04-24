using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        //The implementation of your tasks should look like this:
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1_Low(char c, IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task2_Low(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task3_Low(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task4_Low(int k, IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task5_Low(IEnumerable<int> integerList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task1_Middle(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<int> Task2_Middle(int k, IEnumerable<int> integerList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }
        
        public static IEnumerable<int> Task3_Middle(int k, int d, IEnumerable<int> integerList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task4_Middle(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task5_Middle(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task1_Advance(IEnumerable<Entrant> nameList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<string> Task2_Advance(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<YearSchoolStat> Task3_Advance(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<MaxDiscountOwner> Task4_Advance(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<CountryStat> Task5_Advance(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

    }
}
