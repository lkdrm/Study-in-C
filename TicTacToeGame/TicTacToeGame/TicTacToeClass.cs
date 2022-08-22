using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{

    public enum Winner
    {
        Crosses,
        Zeroes,
        Draw,
        GameUnFinished,
    }
    public enum State
    {
        Cross,
        Zero,
        Unset
    }


    public class TicTacToeClass
    {
        private readonly State[] board = new State[9];

        public int MovesCount { get; private set; }

        public TicTacToeClass()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = State.Unset;
            }
        }

        public void MakeMove(int index)
        {
            board[index - 1] = MovesCount % 2 == 0 ? State.Cross : State.Zero;
            MovesCount++;
        }

        public State GetState(int index)
        {
            return board[index - 1];
        }

        public Winner GetWinner()
        {
            return GetWinner(1,4,7,
                2,5,8,
                3,6,9,
                1,2,3,
                4,5,6,
                7,8,9,
                1,5,9,
                3,5,7);
        }

        private Winner GetWinner(params int[] indexer)
        {
            for(int i=0; i < indexer.Length; i += 3)
            {
                bool same = AreSame(indexer[i], indexer[i + 1], indexer[i + 2]);
                if (same)
                {
                    State state = GetState(indexer[i]);
                    if (state !=State.Unset)
                    {
                        return state == State.Cross ? Winner.Crosses : Winner.Zeroes;
                    }
                }
            }
            if(MovesCount < 9)
            {
                return Winner.GameUnFinished;
            }
            return Winner.Draw;
        }

        private bool AreSame(int a, int b, int c)
        {
            return GetState(a) == GetState(b) && GetState(a) == GetState(c);
        }
    }

}
