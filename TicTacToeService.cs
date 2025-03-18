using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRMI_TicTacToeServer
{
    class TicTacToeService : ITicTacToeService
    {
        private static GameManager gameManager = new GameManager();

        public string MakeMove(int row, int col, char player)
        {
            return gameManager.MakeMove(row, col, player);
        }

        public string GetBoard()
        {
            return gameManager.GetBoard();
        }
    }
}
