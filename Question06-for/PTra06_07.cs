/*
 * PTra06_07.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra06_07
{
    public static void Main(string[] args)
    {
        /*
    	 * TODO 以下のかけ算九九の出力結果が出るようなプログラムを作成してください。
    	 *
    	 * 1  2  3  4  5  6  7  8  9
    	 * 2  4  6  8 10 12 14 16 18
    	 * 3  6  9 12 15 18 21 24 27
    	 * 4  8 12 16 20 24 28 32 36
    	 * 5 10 15 20 25 30 35 40 45
    	 * 6 12 18 24 30 36 42 48 54
    	 * 7 14 21 28 35 42 49 56 63
    	 * 8 16 24 32 40 48 56 64 72
    	 * 9 18 27 36 45 54 63 72 81
    	 */
        for (int i1 = 1; i1 < 10; i1++)
        {
            for (int i2 = 1; i2 < 10; i2++)
            {

                    Console.Write("{0,3}",i1 * i2);

            }
            Console.WriteLine();
        }

    }
}
