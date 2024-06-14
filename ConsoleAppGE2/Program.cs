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
            Player[] players = new Player[playerCntMax];

            // プレイヤー情報追加処理
            for (int i = 0; i < playerCntMax; i++)
            {
                players[i] = new Player();
                players[i].CreatePlayer(i);
            }

            // プレイヤー情報の表示処理
            for (int i = 0; i < playerCntMax; i++)
            {
                players[i].ShowPlayer(i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}
