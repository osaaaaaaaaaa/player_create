﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Player
    {
        /// <summary>
        /// プレイヤーの基本情報 (プロパティを自動実装)
        /// </summary>
        public string playerName { get; private set; }
        public int playerHp {  get; private set; }
        int playerAtk;

        /// <summary>
        /// Player情報作成
        /// </summary>
        public void CreatePlayer(int playerNum)
        {
            Console.WriteLine("\n* [{0}番目] プレイヤー情報を追加します", playerNum);

            // 名前を設定
            Console.Write("1.Name > ");
            this.playerName = Console.ReadLine();

            // HPを設定
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("2.HP   > ");
                bool isSuccess = int.TryParse(Console.ReadLine(), out int setValue);

                if (isSuccess)
                {
                    this.playerHp = setValue;   // playerHpはプロパティの制限でoutに直接指定できないため、outにsetValueを指定してから代入する
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*** ERROR ***\n");
                }
            }

            // ATKを設定
            while (true)
            {
                Console.Write("3.ATK  > ");
                bool isSuccess = int.TryParse(Console.ReadLine(), out this.playerAtk);

                if (isSuccess)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*** ERROR ***\n");
                }
            }

            Console.Clear();
        }

        // Player情報を表示する
        public void ShowPlayer(int playerNum)
        {
            Console.Write("\n\n  * [{0}番目]プレイヤー情報  >>>  ", playerNum);
            Console.Write("[ Name : {0} ]", this.playerName);
            Console.Write("\n\t\t\t\t  HP  -> "+ this.playerHp);
            Console.Write("\n\t\t\t\t  ATK -> "+ this.playerAtk);
        }

        /// <summary>
        /// Playerの攻撃処理 [opp:Opponent]
        /// </summary>
        /// <param name="opp">対戦相手の情報</param>
        public void AttackPlayer(int playerNum,Player opp)
        {
            // HPの減算処理
            opp.playerHp -= this.playerAtk;

            Console.Write("\n\n{0}の攻撃 -> {1}:HP{2}(-{3})"
                , this.playerName, opp.playerName, opp.playerHp, this.playerAtk);
        }
    }
}
