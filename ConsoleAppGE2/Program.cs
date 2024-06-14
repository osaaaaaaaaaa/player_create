using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        // プレイヤー人数
        const int playerCntMax = 2;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // newする
            List<Player> players = new List<Player>();

            // プレイヤー情報追加処理
            for (int i = 0; i < playerCntMax; i++)
            {
                var playerData = new Player();
                playerData.CreatePlayer(i);
                players.Add(playerData);
            }

            // プレイヤー情報の表示処理
            for (int i = 0; i < playerCntMax; i++)
            {
                players[i].ShowPlayer(i);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n##### ENTERで対戦開始 #####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();

            bool isEnd = false;
            // 対戦処理
            while (!isEnd)
            {
                for(int i = 0;i < playerCntMax; i++)
                {
                    // 対戦相手をListから検索する
                    Player opp = players.Find(item => item != players[i]);

                    // 攻撃処理
                    players[i].AttackPlayer(i, opp); // 第二引数に対戦相手を指定

                    Console.ReadLine();

                    // 対戦相手のHPが尽きた場合
                    if (opp.playerHp <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}は力尽きた...。", opp.playerName);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\n★ " + players[i].playerName + "の勝利 ★\n");
                        isEnd = true;
                        break;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}