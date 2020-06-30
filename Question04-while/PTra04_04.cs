﻿/*
 * PTra04_04.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra04_04
{
    public static void Main(string[] args)
    {
        // 以下は双六のプログラムです。TODO の指示に従って完成させてください。

        // ランダムな値を生成するための記述です。
        Random random = new Random();

        // TODO 双六の総コマ数としてint型の変数mapを宣言し、50を代入してください。
        int map = 50;

        // TODO 現在までの進んだコマ数としてint型の変数progressを宣言し、0を代入してください。
        int progress = 0;

        Console.WriteLine("===== START =====");

        // TODO 変数mapとprogressを用いて、ゴールするまで繰り返すようにwhile文の条件を記述してください。
        while (progress < map)
        {
            // 入力を促すメッセージを出力し、エンターキーが押されるのを待ちます。
            Console.WriteLine("Enterキーを押してください。さいころをふります。");
            Console.ReadLine();

            // 1~6のランダムな値を生成してさいころの目とします。
            int dice = random.Next(1, 7);

            // TODO 変数diceを用いて、"#の目が出ました。"というメッセージを出力してください。
            // ※ #には変数diceの値が入ります。
            Console.WriteLine($"{dice}の目が出ました。");

            // TODO 変数progressに変数diceの値を加算してください。
            progress = progress + dice;

            // TODO まだゴールしていない場合は"残りのマスは#マスです。"というメッセージを出力してください。
            // ※ #には双六の残りのマス数が入ります。
            if (progress < map)
            {
                Console.WriteLine($"残りのマスは{map - progress}マスです。");
            }

        }
        Console.WriteLine("===== GOAL =====");
    }
}
