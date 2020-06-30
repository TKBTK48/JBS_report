/*
 * PTra02_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra02_01
{
    public static void Main(string[] args)
    {
        int sum;
        int diff;
        int mulch;
        int div;
        int rem;

        // TODO 6+2を計算して結果を変数sumに代入してください

        // TODO 6-2を計算して結果を変数diffに代入してください

        // TODO 6×2を計算して結果を変数mulchに代入してください

        // TODO 6÷2を計算して結果を変数divに代入してください

        // TODO 12÷5の余りを計算して変数remに代入してください

        // 各変数の表示(編集しないでください)
        // ※ 8, 4, 12, 3, 2の順で表示されれば正解です
        sum = 6 + 2;
        Console.WriteLine("変数sum :" + sum);
        diff = 6 - 2;
        Console.WriteLine("変数diff :" + diff);
        mulch = 6 * 2;
        Console.WriteLine("変数mulch:" + mulch);
        div = 6 / 2;
        Console.WriteLine("変数div  :" + div);
        rem = 12 % 5;
        Console.WriteLine("変数rem  :" + rem);
    }
}
