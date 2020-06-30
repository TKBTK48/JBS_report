/*
 * PTra07_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra07_05
{
    public static void Main(string[] args)
    {
        string[] array = new string[5];
        array[0] = "森";
        array[1] = "山";
        array[2] = "沼";
        array[3] = "島";
        array[4] = "平地";

        // 0~4のランダムな整数を作成しています
        int random = new Random().Next(0,5);

        // TODO 配列arrayから変数randomが示す要素を出力してください

        
        
          Console.WriteLine(array[random]);






        
    }
}
