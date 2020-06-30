/*
 * PTra07_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra07_04
{
    public static void Main(string[] args)
    {
        int[] array = new int[1000];

        // TODO 配列arrayに1から1000までの整数を順に入れてください
        // ※ for文を用いて代入を行うこと

        int i;

        for ( i =0; i < 1000; i++ )
        {
            array[i] += i + 1;            //array[i] = array[i] + i + 1  左と右は同じ意味を表している。

            Console.WriteLine(array[i]);


        }


        // TODO 配列arrayの全要素を順番に出力してください









    }
}
