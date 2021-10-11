using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length > 1 && s.StartsWith(c) && s.EndsWith(c));
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.Length).OrderBy(s => s).AsEnumerable();
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.First().ToString() + s.Last().ToString());
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length == k && char.IsDigit(s.ToArray().Last()) && char.IsDigit(s.ToArray().Last())).OrderBy(s => s);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(i => i % 2 != 0).Select(s => s.ToString()).OrderBy(s => int.Parse(s));
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            return numbers.Select(n => stringList.FirstOrDefault(s => s.Length == n && char.IsDigit(s[0]))?? "Not found");
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            return integerList.Where(i => i % 2 == 0).Except(integerList.Skip(k)).Reverse();
        }
        
        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            return integerList.TakeWhile(i => i <= d).Union(integerList.Skip(k)).OrderByDescending(i => i);
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(s => s.Substring(0, 1));
        }

        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            //TODO :Delete line below and write your own solution
            throw new NotImplementedException();
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

    }
}
