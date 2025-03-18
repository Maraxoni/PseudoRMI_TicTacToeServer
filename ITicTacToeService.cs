using CoreWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRMI_TicTacToeServer
{
    [ServiceContract]
    interface ITicTacToeService
    {
        [OperationContract]
        string MakeMove(int row, int col, char player);

        [OperationContract]
        string GetBoard();
    }
}
