using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqS1
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region 1 - Get all products from the "Seafood" category.Print each product's name and price.
            //var result = ProductList.Where(P => P.Category == "Seafood");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2 - Get a list of only the product names from ProductList. Print each name.
            //var result =  ProductList.Select(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3 - Sort all products by UnitPrice (ascending). Print each product's name and price.
            //   var result = from p in ProductList
            //    orderby p.UnitPrice ascending
            //    select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4 - Get all products where UnitPrice is between 10 and 30
            //var result = ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5 - Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6 - Create a new anonymous type with three properties:
            // ● Name → the product name
            // ● Price → the unit price
            // ● StockStatus → a string: "Available" if UnitsInStock > 0 , otherwise "Out of Stock"
            // ● Print the result.

            //var result = from p in ProductList
            //             select new
            //             {
            //                 Name = p.ProductName,
            //                 Price = p.UnitPrice,
            //                 StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            //}

            #endregion

            #region 7 - Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var result = ProductList.Select((P, index) => new
            //{
            //    P.ProductName,
            //    index
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.index + 1}. {item.ProductName}");
            //}


            #endregion

            #region 8 -  Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var result =  from p in ProductList
            //orderby p.Category, p.UnitPrice descending
            //select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region 9 -  Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            // in this case i use orderby descending method instead of orderby descending keyword to sort the product desired by stock in descending order

            //var result = ProductList.Where(P => P.Category == "Beverages").OrderByDescending(P => P.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10 -   Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var result = from C in CustomerList
            //from O in C.Orders
            //where O.OrderDate.Year >= 1997
            //select new { C.CustomerID, O.OrderDate };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 11 - Show position number alongside ProductName
            //var result = ProductList.Select((P, index) => new { P.ProductName, index });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.index}. {item.ProductName}");
            //}

            #endregion

            #region 12 - Sort first by-word length and then by a case - insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderByDescending(ele => ele);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 13 - Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //var result = CustomerList.Where(c => c.CompanyName[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



        }

    }
}