using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using day10_G01;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Problem 1
            // var Result = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 2
            // var Result = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 3
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // var Result = Arr.Where((word, index) => word.Length < index);

            // foreach (var word in Result)
            // {
            //     Console.WriteLine(word);
            // }
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region Problem 1
            // var Result = ListGenerators.ProductList.First(p => p.UnitsInStock == 0);
            // Console.WriteLine(Result);
            #endregion

            #region Problem 2
            // var Result = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            // Console.WriteLine("Is it null? " + (Result == null));
            #endregion

            #region Problem 3
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = Arr.Where(p => p > 5)
            //                 .ElementAtOrDefault(1);
            // Console.WriteLine(Result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region Problem 1
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // int Result = Arr.Count(p => p % 2 == 1);
            // Console.WriteLine(Result);
            #endregion

            #region Problem 2
            // var Result = ListGenerators.CustomerList.Select(c => (c.Name, c.Orders.Length));

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 3
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             ProductCount = p.Count()
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = Arr.Sum();
            // Console.WriteLine(Result);
            #endregion

            #region Problem 5
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // var Result = Words.Sum(w => w.Length);
            // Console.WriteLine($"Total characters = {Result}");
            #endregion

            #region Problem 6
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             ProductCount = p.Sum(product => product.UnitsInStock)
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 7
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // var Result = Words.Min(w => w.Length);
            // Console.WriteLine($"Total characters = {Result}");
            #endregion

            #region Problem 8
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             Price = p.Min(product => product.UnitPrice)
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 10
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // var Result = Words.Max(w => w.Length);
            // Console.WriteLine($"Total characters = {Result}");
            #endregion

            #region Problem 11
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             Price = p.Max(product => product.UnitPrice)
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 12
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             Price = p.Max(product => product.UnitPrice)
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 13
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // var Result = Words.Average(w => w.Length);
            // Console.WriteLine($"Total characters = {Result}");
            #endregion

            #region Problem 14
            // var Result = ListGenerators.ProductList.GroupBy(c => c.Category)
            //                                         .Select(p => new
            //                                         {
            //                                             Category = p.Key,
            //                                             Price = p.Average(product => product.UnitPrice)
            //                                         });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Problem 1
            // var Result = ListGenerators.ProductList.OrderBy(p => p.ProductName.Length);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.ProductName);
            // }
            #endregion

            #region Problem 2
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var Result = Arr.OrderBy(p => StringComparer.OrdinalIgnoreCase);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 3
            // var Result = ListGenerators.ProductList.OrderByDescending(p => p.UnitsInStock);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.UnitsInStock);
            // }
            #endregion

            #region Problem 4
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // var Result = Arr.OrderBy(l => l.Length)
            //                 .ThenBy(a => a);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 5
            // string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var Result = words.OrderBy(l => l.Length)
            //                     .ThenBy(a => a, StringComparer.OrdinalIgnoreCase);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 6
            // var Result = ListGenerators.ProductList.OrderByDescending(p => p.Category)
            //                                         .ThenByDescending(p => p.UnitPrice);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            // }
            #endregion

            #region Problem 7
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var Result = Arr.OrderByDescending(l => l.Length)
            //                     .ThenByDescending(a => a, StringComparer.OrdinalIgnoreCase);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 8
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // var Result = Arr.Where(a => a[1] == 'i')
            //                 .Reverse();

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #endregion

            #region LINQ - Transformation Operators

            #region Problem 1
            // var Result = ListGenerators.ProductList.Select(p => p.ProductName);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 2
            // string[] Words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            // var Result = Words.Select(p => new
            // {
            //     UpperCase = p.ToUpper(),
            //     LowerCase = p.ToLower()
            // });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 3
            // var Result = ListGenerators.ProductList.Select(p => new
            // {
            //     p.ProductID,
            //     p.ProductName,
            //     Price = p.UnitPrice
            // });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 4
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = Arr.Select((num, index) => new
            // {
            //     Number = num,
            //     InPlace = num == index
            // });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 5
            // int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] NumbersB = { 1, 3, 5, 7, 8 };

            // var Result = from A in NumbersA
            //              from B in NumbersB
            //              where A < B
            //              select new { A, B };

            // foreach (var item in Result)
            // {
            //     Console.WriteLine($"{item.A} is less than {item.B}");
            // }
            #endregion

            #region Problem 6
            // var Result = ListGenerators.CustomerList.SelectMany(c => c.Orders)
            //                                         .Where(o => o.Total > 500.00);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 7
            // var Result = ListGenerators.CustomerList.SelectMany(c => c.Orders)
            //                                         .Where(o => o.OrderDate.Year > 1998);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region Problem 1
            // //var Result = ListGenerators.CustomerList.Where(c => c.City == "México D.F.")
            // var Result = ListGenerators.CustomerList.Where(c => c.City == "Washington")
            //                                         .SelectMany(c => c.Orders)
            //                                         .Take(3);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 2
            // //var Result = ListGenerators.CustomerList.Where(c => c.City == "México D.F.")
            // var Result = ListGenerators.CustomerList.Where(c => c.City == "Washington")
            //                                         .SelectMany(c => c.Orders)
            //                                         .Skip(2);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 3
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = numbers.TakeWhile((num, index) => num >= index);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 4
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = numbers.SkipWhile(num => num % 3 != 0);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Problem 5
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = numbers.SkipWhile((num, index) => num >= index);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region Problem 1
            // string[] Words = File.ReadAllLines("dictionary_english.txt");

            // var Result = Words.Any(w => w.Contains("ei"));
            // Console.WriteLine($"Total characters = {Result}");
            #endregion

            #region Problem 2
            // var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                          .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                                                          .Select(g => new
            //                                                          {
            //                                                              Category = g.Key,
            //                                                              Products = g
            //                                                          });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine("-----------------------------------------------------");
            //     Console.WriteLine(item.Category);
            //     Console.WriteLine("-----------------------------------------------------");
            //     foreach (var product in item.Products)
            //         Console.WriteLine("     " + product.ProductName);
            // }
            #endregion

            #region Problem 3
            // var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                                      .Where(g => g.All(p => p.UnitsInStock > 0))
            //                                                      .Select(g => new
            //                                                      {
            //                                                          Category = g.Key,
            //                                                          Products = g
            //                                                      });

            // foreach (var item in Result)
            // {
            //     Console.WriteLine("-----------------------------------------------------");
            //     Console.WriteLine(item.Category);
            //     Console.WriteLine("-----------------------------------------------------");
            //     foreach (var product in item.Products)
            //         Console.WriteLine("     " + product.ProductName);
            // }
            #endregion

            #endregion
        }
    }
}
