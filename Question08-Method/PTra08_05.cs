/*
 * PTra08_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra08_05
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1つ目の数値を入力してください");
        // キーボードから入力した文字列を num1 に代入します。
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2つ目の数値を入力してください");
        // キーボードから入力した文字列を num2 に代入します。
        int num2 = int.Parse(Console.ReadLine());

        // TODO num1、num2を引数で渡してSumメソッドを呼び出し、戻り値を変数 sum に代入してください。
        int sum = Sum(num1, num2);

        // TODO 変数 sum の値を出力してください。
        Console.WriteLine($"{sum}");

    }


    /*
  	 * TODO 以下の仕様でメソッドを作成してください。
  	 *
  	 * 戻り値		：int
  	 * メソッド名	：Sum
  	 * 引数		：int x, int y
  	 *
  	 * 引数で渡された２つのint型の合計を返すメソッド
  	 */
    public static int Sum(int x, int y)
    {
        return x + y;
    }

}
