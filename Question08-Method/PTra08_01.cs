/*
 * PTra08_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2019, 10, 8);
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            Console.WriteLine("{0}年{1}月{2}日", year, month, day);
            var date1 = date.AddDays(1);
            var date2 = date.AddDays(6);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
        }
    }
}
