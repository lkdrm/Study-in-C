using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public enum Player
    {
        PC,
        Player
    }

    public enum GameStatus 
    {
        NotStarted,
        InProgress,
        GameIsOver,
    }
    public class ChineSticks
    {
        private readonly Random randomizer;

        public int InitialSticks { get; }

        public Player Turn { get; private set; }

        public int RemainingSticks { get; private set; }

        public GameStatus GameStatus { get; private set; }

        public event Action<int> PcPlay;
        public event EventHandler<int> PlayerPlay;
        public event Action<Player> EndOfGame;

        public ChineSticks(int initialSticks, Player turn)
        {
            if(initialSticks < 7 || initialSticks > 30)
            {
                throw new ArithmeticException("Initial number of sticks must be >7 and <30");
            }

            randomizer = new Random();
            InitialSticks = initialSticks;
            Turn = turn;
            RemainingSticks = InitialSticks;
            GameStatus = GameStatus.NotStarted;
        }

        public void PlayerTake(int sticks)
        {
            if(sticks <1 || sticks > 3)
            {
                throw new ArgumentException("You can take only from 1 to 3 stick");
            }
            else if (sticks > RemainingSticks)
            {
                throw new ArgumentException($"You can`t take more than {RemainingSticks}");
            }
            TakeStick(sticks);
        }

        public void Start()
        {
            if(GameStatus == GameStatus.GameIsOver)
            {
                RemainingSticks = InitialSticks;
            }
            else if (GameStatus == GameStatus.InProgress)
            {
                throw new InvalidOperationException("Can`t start when the game is already run.");
            }

            GameStatus = GameStatus.InProgress;
            while(GameStatus == GameStatus.InProgress)
            {
                if(Turn == Player.PC)
                {
                    PcMakeMove();
                }
                else
                {
                    PlayerMakeMove();
                }

                EndOfGameRequired();

                Turn = Turn == Player.PC ? Player.Player : Player.PC;
            }
        }

        private void EndOfGameRequired()
        {
            if (RemainingSticks == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame != null)
                {
                    EndOfGame(Turn == Player.PC ? Player.Player : Player.PC);
                }
            }
        }

        private void PlayerMakeMove()
        {
            if (PlayerPlay != null)
            {
                PlayerPlay(this,RemainingSticks);
            }
        }

        private void PcMakeMove()
        {
            int maxNumber = RemainingSticks >=3 ? 3: RemainingSticks;
            int stick = randomizer.Next(1, maxNumber);

            TakeStick(stick);
            if (PcPlay != null)
            {
                PcPlay(stick);
            }
        }

        private void TakeStick(int stick)
        {
            RemainingSticks -= stick;
        }
    }
}
