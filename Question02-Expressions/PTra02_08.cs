/*
 * PTra02_08.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra02_08
{
    public static void Main(string[] args)
    {
        // 所持金
        int money = 1000;
        // 商品価格(税抜)
        int price = 580;
        // 消費税率
        double taxRate = 0.08;

        // TODO 買い物した際の残金計算をします。
        // TODO 所持金から価格を引いた値を、買い物後の所持金として再代入してください。
        // ※消費税を考慮してください。税込み商品価格の端数は切り捨てとします。
        money = money - (int)(price * (1 + taxRate));


        // 残金の表示部分です。編集しないでください
        Console.WriteLine("残金は" + money + "円です。");
    }
}
