/*
 * PTra06_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra06_03
{
    public static void Main(string[] args)
    {
        // iが0から100になるまで繰り返しを行います
        for (int i = 0; i < 100; i++)
        {
            // TODO iが偶数の時だけ、iの値を出力してください
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

        }
    }
}
