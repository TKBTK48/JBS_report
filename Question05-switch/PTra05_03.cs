/*
 * PTra05_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra05_03
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("               ゲームの説明");
        Console.WriteLine("=========================================");

        Console.WriteLine("これからハイ＆ローゲームを行います。");
        Console.WriteLine("ハイ＆ローゲームは、あなたのカードがディーラーのカードより大きいか小さいかを予想するゲームです。");

        Console.WriteLine();
        Console.WriteLine("=========================================");
        Console.WriteLine("               ゲーム開始");
        Console.WriteLine("=========================================");

        Random rnd = new Random();

        // ランダムな数値を dealerCard に代入します。(範囲は 1 ~ 13)
        int dealerCard = rnd.Next(1,14);

        Console.WriteLine("ディーラーのカードは" + dealerCard + "です");

        // ランダムな数値を myCard に代入します。(範囲は 1 ~ 13)
        int myCard = rnd.Next(1,14);

        Console.WriteLine();
        Console.WriteLine("あなたのカードがディーラのカードより大きい場合は H 小さい場合は L を入力してください。");
        Console.WriteLine("※ カードの数値が同じ場合はあなたの勝ちです。");

        // キーボードから入力した文字列を judgment に代入します。
        string judgment = Console.ReadLine();

        Console.WriteLine("あなたのカードは" + myCard + "です");

        Console.WriteLine();
        Console.WriteLine("=========================================");
        Console.WriteLine("               勝敗判定");
        Console.WriteLine("=========================================");

        // TODO 予想が当たった場合は「あなたの勝ちです」、外れた場合は「あなたの負けです」を出力してください。
        // ※ H か L 以外の文字が入力された場合は、「不正な値が入力されました」と出力してください。
        
    }
}
