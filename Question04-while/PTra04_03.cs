/*
 * PTra04_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra04_03
{
    public static void Main(string[] args)
    {
        // 乱数生成処理
        Random random = new Random();
        // 乱数を格納するための変数を初期化
        int randomNumber = 0;

        // 以下のwhile文は0~9のランダムな値をコンソールに出力する処理を無限に繰り返します。
        // TODO 5が出力されたら繰り返しを止めるようにしてください。
        // ※ while文の条件は変更せずにbreak文を使ってください。
        while (true)
        {
            // 0~9のランダムな値を生成
            randomNumber = random.Next(10);
            // 生成した値をコンソールに出力
            Console.WriteLine(randomNumber);
            if (randomNumber == 5)
            {
                break;
            }

        }
    }
}
