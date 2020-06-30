/*
 * PTra06_06.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra06_06
{
    public static void Main(string[] args)
    {
        // TODO for文を使って以下の出力結果が出るようなプログラムを作成してください。
        /*
    	 * ■■■■■
    	 * ■■■■■
    	 * ■■■■■
    	 * ■■■■■
    	 * ■■■■■
    	 */
        for (int i1 = 0; i1 < 5; i1++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }

    }
}
