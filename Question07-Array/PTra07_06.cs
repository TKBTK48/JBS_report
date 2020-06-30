/*
 * PTra07_06.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra07_06
{
    public static void Main(string[] args)
    {
        string[] array = new string[5];
        array[0] = "森";
        array[1] = "山";
        array[2] = "沼";
        array[3] = "島";
        array[4] = "平地";

        // TODO 配列arrayの内容を末尾から先頭に向けて順に出力してください
        // ※ 繰り返しを使用して記述すること

        /*   int i;

           for (i = 4; i >= 0;  i-- )
           {
               Console.WriteLine(array[i]);
           }

         int i;

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(array[i]);
        }
         
        */

        int i;

         for (i = 0; i <5; i++)
        {
            if( i % 2 != 0)
            {
                Console.WriteLine(array[i]);
            }
        }
         
         
         
               


        




        Console.WriteLine();

    }
}
