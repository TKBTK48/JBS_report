﻿/*
 * PTra12_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;
using Question12_Extends.common;

public class PTra12_03
{
    /*
  	 * TODO common内に、Characterクラスを継承した、Heroクラスを作成してください
  	 * 	●HP, POWER, ENDURANCEはそれぞれ、（25, 10, 7）
  	 */

    public static void Main(string[] args)
    {
        // TODO Heroクラスをインスンタンス化してください
        var herosample = new Hero();


        // TODO Heroインスタンスのnameフィールドに 勇者 を設定して下さい
        herosample.SetName("勇者");


        // TODO Heroインスタンスのキャラクター情報を表示してください
        Console.WriteLine(herosample.ShowParameter());

    }
}
