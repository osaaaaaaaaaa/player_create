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

            for(int i = 0; i < playerCntMax; i++)
            {
                // プレイヤー情報追加処理
                players[i] = new Player();
                players[i].CreatePlayer(i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}
