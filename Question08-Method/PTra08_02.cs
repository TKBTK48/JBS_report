/*
 * PTra08_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra08_02
{
    public static void Main(string[] args)
    {
        // TODO  引数に 山田 を渡してHelloメソッドを呼び出してください。
        string name1 = "山田";
        Hello(name1);

    }

    public static void Hello(string name)
    {
        Console.WriteLine("こんにちは。" + name + "です");
    }
}
