/*
 * Jam.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class Jam
{

<<<<<<< HEAD
    /* 
    *  TODO 以下のプロパティを作成してください
    *  型：string型
    *  フィールド名：material
    */
=======
    // TODO string型のmaterialフィールドを作成してください。
    public static string material { get; set; }
>>>>>>> 0675db6c968e9aa732fdb1b268e03a336db7c4eb


    /*
  	 *  TODO string型の引数を1つ持つもつコンストラクタを作成してください。
  	 *  処理：与えられた引数をmaterialフィールドに代入する
  	 */
    public Jam(string inputmaterial)
    {
        material = inputmaterial;
    }

    /*
  	 *  TODO GetInfoメソッドを作成してください
  	 *  引数		：なし
  	 *  戻り値	：xx味のジャムです。 ※ xxには material の値が入る
  	 */

    public string GetInfo()
    {
        return $"{material}味のジャムです。";
    }

}
