/*
 * PTra08_06.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra08_06
{
    public static void Main(string[] args)
    {
        PrintValue("こんにちは");
        PrintValue(100);
        PrintValue(10.1);
        PrintValue('A');
    }

    /*
  	 * TODO 以下の仕様でメソッドを作成してください
  	 *
  	 * 戻り値		：void
  	 * メソッド名	：PrintValue
  	 * 引数		：string value
  	 *
  	 * 引数はxxxですと表示するメソッド(xxxには渡された引数を当てはめる)
  	 */
    public static void PrintValue(string value)
    {
        Console.WriteLine($"引数は{value}です");
    }

    // TODO printValueを引数intでオーバーロードしてください。処理は同じ
    public static void PrintValue(int value)
    {
        Console.WriteLine($"引数は{value}です");
    }

    // TODO printValueを引数doubleでオーバーロードしてください。処理は同じ
    public static void PrintValue(double value)
    {
        Console.WriteLine($"引数は{value}です");
    }

    // TODO printValueを引数charでオーバーロードしてください。処理は同じ
    public static void PrintValue(char value)
    {
        Console.WriteLine($"引数は{value}です");
    }

}
