/*
 * PTra08_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class PTra08_04
{
    public static void Main(string[] args)
    {
        // TODO 引数に 1 と 2 を渡してSumメソッドを呼び出し、戻り値を、変数 sum に代入してください
        int x = 1;
        int y = 2;
        var sum = Sum(x,y);

        // TODO sum の値を出力してください
        Console.WriteLine($"{sum}");

    }

    public static int Sum(int x, int y)
    {
        return x + y;
    }
}
