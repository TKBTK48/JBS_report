/*
 * PTra03_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;
public class PTra03_04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("降水確率を入力してください。（数字のみ）");

        // キーボードから入力した数値を変数 num に代入します
        int num = int.Parse(Console.ReadLine());

        // TODO 以下の条件に沿ったプログラムを記述してください
        /*
    	 * 入力された数値によって以下のように出力してください。
    	 * 変数numの値が 75以上 の場合			->	雨が降る確率が高いです
    	 * 変数numの値が 30～74 の場合			->	雨が降るかもしれないです
    	 * 変数numの値が 30未満 の場合			->	雨はまず降らないでしょう
    	 *
    	 * ※ 変数numの値が 0より小さい または 100より大きい場合は「不正な値が入力されました」と出力してください。
    	 */
        if (100 >= num && num >= 75)
        {
            Console.WriteLine("雨が降る確率が高いです");
        }
        else if (74 >= num && num >= 30)
        {
            Console.WriteLine("雨が降るかもしれないです");
        }
        else if (30 > num && num >= 0)
        {
            Console.WriteLine("雨はまず降らないでしょう");
        }
        else
        {
            Console.WriteLine("不正な値が入力されました");
        }


    }
}
