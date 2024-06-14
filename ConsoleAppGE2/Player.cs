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
        /// プレイヤーの基本情報
        /// </summary>
        string palyerName;
        int playerHp;
        int playerAtk;


        /// <summary>
        /// Player情報作成
        /// </summary>
        public void CreatePlayer(int playerNum)
        {
            Console.WriteLine("\n* [{0}番目] プレイヤー情報を追加します", playerNum);

            // 名前を設定
            Console.Write("1.Name > ");
            this.palyerName = Console.ReadLine();

            // HPを設定
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("2.HP > ");
                bool isSuccess = int.TryParse(Console.ReadLine(), out this.playerHp);

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

            // ATKを設定
            while (true)
            {
                Console.Write("3.ATK > ");
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
    }
}
