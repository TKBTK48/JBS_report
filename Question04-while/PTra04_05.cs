/*
 * PTra04_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra04_05
{
    public static void Main(string[] args)
    {
        // 以下はじゃんけんを行うプログラムです。
        // TODO TODOコメントの指示に従ってプログラムを完成させてください。

        // 乱数生成処理
        Random random = new Random();

        // 勝敗の状態を覚えておくための変数(初期値は負けとする)
        bool winFlag = false;

        // プレイヤーが勝つまでじゃんけんを繰り返す。
        while (!winFlag)
        {
            int playerHand;
            int npcHand;

            // プレイヤーに出す手を選ばせる
            // ※ 数値でない入力は考慮していません(エラーになります)
            Console.WriteLine("じゃんけんを行います。");
            Console.WriteLine("あなたの出す手を入力してください");
            Console.WriteLine("0:グー, 1:チョキ, 2:パー");
            playerHand = int.Parse(Console.ReadLine());
            // TODO 選ばれた手を出力してください(0なら"あなたはグーを出しました"等)
            if (playerHand == 0)
            {
                Console.WriteLine("あなたはグーを出しました");
            }
            else if(playerHand == 1)
            {
                Console.WriteLine("あなたはチョキを出しました");
            }
            else if (playerHand == 2)
            {
                Console.WriteLine("あなたはパーを出しました");
            }
            // 対戦相手の手をランダムに選択する。
            npcHand = random.Next(3);
            // TODO 対戦相手の手を出力してください(0なら"相手はグーを出しました"等)
            if (npcHand == 0)
            {
                Console.WriteLine("相手はグーを出しました");
            }
            else if (npcHand == 1)
            {
                Console.WriteLine("相手はチョキを出しました");
            }
            else if (npcHand == 2)
            {
                Console.WriteLine("相手はパーを出しました");
            }
            // TODO じゃんけんの結果を出力してください。
            // TODO プレイヤーが勝った場合はプログラムが終了するようにしてください。
            if ((playerHand == 0&&npcHand==1)|| (playerHand == 1 && npcHand == 2)|| (playerHand == 2 && npcHand == 0))
            {
                Console.WriteLine("あなたは勝ちました");
                winFlag = true;
            }
            else if(playerHand==npcHand)
            {
                Console.WriteLine("引き分けでした");
            }

            else
            {
                Console.WriteLine("あなたは負けました");
            }

            // 次のじゃんけんの前に改行しておく
            Console.WriteLine();
        }
    }
}
