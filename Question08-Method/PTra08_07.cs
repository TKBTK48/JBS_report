/*
 * PTra08_07.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra08_07
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Sum(1, 2, 3, 4));
    }

    /*
  	 * TODO 以下の仕様でメソッドを作成してください
  	 *
  	 * 戻り値		：int
  	 * メソッド名	：Sum
  	 * 引数		：int num1, int num2
  	 *
  	 * 引数で渡された値合計した値を戻り値として返す
  	 */
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    //TODO Sumを引数3つでオーバーロードしてください。処理は同じ
    public static int Sum(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    //TODO Sumを引数4つでオーバーロードしてください。処理は同じ
    public static int Sum(int num1, int num2, int num3, int num4)
    {
        return num1 + num2 + num3 + num4;
    }

}
