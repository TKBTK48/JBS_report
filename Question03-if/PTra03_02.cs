/*
 * PTra03_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

public class PTra03_02
{
    public static void Main(string[] args)
    {
        // TODO int型の変数numを宣言し、65で初期化してください
        int num = 65;

        // TODO 変数numの値が65以上の場合は「合格です」と出力し、それ以外であれば「不合格です」を出力してください
        // ※ 合格です と表示されれば正解
        if (num >= 65)
        {
            Console.WriteLine("合格です");
        }
        else
        {
            Console.WriteLine("不合格です");
        }
    }
}
