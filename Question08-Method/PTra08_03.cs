/*
 * PTra08_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra08_03
{
    public static void Main(string[] args)
    {
        // TODO string型の str という変数にHelloメソッドの戻り値を代入してください
        string str = Hello();
        // TODO str の値を出力してください
        Console.WriteLine($"{str}");
    }

    public static string Hello()
    {
        return "こんにちは";
    }
}
