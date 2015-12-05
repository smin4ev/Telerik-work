using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mines
{
	public class Minite
	{
		public class Points
		{
			string name;
			int points;

			public string Name
			{
                get { return name; }
                set { name = value; }
			}

			public int Dots
			{
				get { return points; }
				set { points = value; }
			}

			public Points() { }

			public Points(string name, int points)
			{
                this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] arguments)
		{
			string command = string.Empty;
            char[,] field = CreateGameField();
			char[,] bombs = InsertBombs();
			int counter = 0;
			bool thunder = false;
			List<Points> champions = new List<Points>(6);
			int row = 0;
			int cols = 0;
			bool flag = true;
			const int maxTurns = 35;
			bool secondFlag = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Lets play   “Mine Game”. Try your luck and find fields without mines." +
                    " Command 'top' show the ranking, 'restart' - began new game, 'exit'  - exist and ByeBye!");
					Dump(field);
					flag = false;
				}
				Console.Write("Write row and column with numbers and interval between them : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out cols) &&
						row <= field.GetLength(0) && cols <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Rate(champions);
						break;
					case "restart":
						field = CreateGameField();
                        bombs = InsertBombs();
						Dump(field);
						thunder = false;
						flag = false;
						break;
					case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
						break;
					case "turn":
                        if (bombs[row, cols] != '*')
						{
                            if (bombs[row, cols] == '-')
							{
                                ChangeTurn(field, bombs, row, cols);
								counter++;
							}
							if (maxTurns == counter)
							{
								secondFlag = true;
							}
							else
							{
								Dump(field);
							}
						}
						else
						{
							thunder = true;
						}
						break;
					default:
						Console.WriteLine("\nMistake! invalid command\n");
						break;
				}
				if (thunder)
				{
                    Dump(bombs);
					Console.Write("\nHrrrrrr!End of the game with {0} points. " +
						"Give your username: ", counter);
					string username = Console.ReadLine();
					Points pointsInGame = new Points(username, counter);
					if (champions.Count < 5)
					{
						champions.Add(pointsInGame);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
							if (champions[i].Dots < pointsInGame.Dots)
							{
								champions.Insert(i, pointsInGame);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
					champions.Sort((Points r1, Points r2) => r2.Dots.CompareTo(r1.Dots));
					Rate(champions);

					field = CreateGameField();
                    bombs = InsertBombs();
					counter = 0;
					thunder = false;
					flag = true;
				}
				if (secondFlag)
				{
					Console.WriteLine("\nGood job! 35 tries without mistake.");
                    Dump(bombs);
					Console.WriteLine("Please, enter your name: ");
					string imeee = Console.ReadLine();
					Points dots = new Points(name, counter);
					champions.Add(dots);
					Rate(champions);
					field = CreateGameField();
                    bombs = InsertBombs();
					counter = 0;
					secondFlag = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("Come on.");
			Console.Read();
		}

        private static char[,] CreatField()
        {
            throw new NotImplementedException();
        }

        private static void Rate(List<Points> champions)
        {
            throw new NotImplementedException();
        }

		private static void Rating(List<Points> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, points[i].Name, points[i].Dots);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("empry rating!\n");
			}
		}

		private static void ChangeTurn(char[,] FIELD,
			char[,] BOMBS, int ROW, int COLS)
		{
			char bombs = counter(BOMBS, ROW, COLS);
			BOMBS[ROW, COLS] = bombs;
			FIELD[ROW, COLS] = bombs;
		}

		private static void Dump(char[,] board)
		{
			int firstBoardLength = board.GetLength(0);
			int secondBoardLength = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < firstBoardLength; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < secondBoardLength; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] InsertBombs()
		{
			int Rows = 5;
			int Cols = 10;
			char[,] gameField = new char[Rows, Cols];

			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Cols; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> position = new List<int>();
			while (position.Count < 15)
			{
				Random random = new Random();
				int numberInGame = random.Next(50);
				if (!position.Contains(numberInGame))
				{
					position.Add(numberInGame);
				}
			}

			foreach (int pos in position)
			{
				int row = (pos / Cols);
				int cols = (pos % Cols);
				if (cols == 0 && pos != 0)
				{
					row--;
					cols = Cols;
				}
				else
				{
					cols++;
				}
				gameField[row, cols - 1] = '*';
			}

			return gameField;
		}

		private static void accounts(char[,] pole)
		{
			int cols = pole.GetLength(0);
			int red = pole.GetLength(1);

			for (int i = 0; i < cols; i++)
			{
				for (int j = 0; j < red; j++)
				{
					if (pole[i, j] != '*')
					{
						char howMuch = how(pole, i, j);
						pole[i, j] = howMuch;
					}
				}
			}
		}

        private static char how(char[,] pole, int i, int j)
        {
            throw new NotImplementedException();
        }

		private static char counter(char[,] firstTurn, int secondTurn, int thirdTurn)
		{
			int counter = 0;
			int rows = firstTurn.GetLength(0);
			int cols = firstTurn.GetLength(1);

			if (secondTurn - 1 >= 0)
			{
				if (firstTurn[secondTurn - 1, thirdTurn] == '*')
				{ 
					counter++; 
				}
			}
			if (secondTurn + 1 < rows)
			{
				if (firstTurn[secondTurn + 1, thirdTurn] == '*')
				{ 
					counter++; 
				}
			}
			if (thirdTurn - 1 >= 0)
			{
				if (firstTurn[secondTurn, thirdTurn - 1] == '*')
				{ 
					counter++;
				}
			}
			if (thirdTurn + 1 < cols)
			{
				if (firstTurn[secondTurn, thirdTurn + 1] == '*')
				{ 
					counter++;
				}
			}
			if ((secondTurn - 1 >= 0) && (thirdTurn - 1 >= 0))
			{
				if (firstTurn[secondTurn - 1, thirdTurn - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((secondTurn - 1 >= 0) && (thirdTurn + 1 < cols))
			{
				if (firstTurn[secondTurn - 1, thirdTurn + 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((secondTurn + 1 < rows) && (thirdTurn - 1 >= 0))
			{
				if (firstTurn[secondTurn + 1, thirdTurn - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((secondTurn + 1 < rows) && (thirdTurn + 1 < cols))
			{
				if (firstTurn[secondTurn + 1, thirdTurn + 1] == '*')
				{ 
					counter++; 
				}
			}
			return char.Parse(counter.ToString());
		}

        public static string name { get; set; }
    }
}
