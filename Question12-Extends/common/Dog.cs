﻿/*
* Dog.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

// TODO 同一フォルダのAnimalクラスを継承してください
namespace common
{
    public class Dog : Animal
    {
        /*
         * TODO Eatメソッドをオーバーライドして以下の内容が出力されるようにしてください。
         * name はドッグフードを食べました
         * ※ name には name フィールドの値が入る
         */

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"{this.GetName()}はドッグフードを食べました");
        }

    }
}