using System;

public class TicTacToe
{
  private string[] board = new string[9];
  private bool isPlayerOneTurn;
  public static void Main()
  {
    TicTacToe ttt = new TicTacToe();
      ttt.Start();
  }
  
  public void ShowGameStartScreen()
  {
    Console.WriteLine("Welcome to Tic-Tac-Toe!");
  }

  public TicTacToe()
  {
    
  }
  public void Start()
  {
    Init();
    ShowGameStartScreen();
    ShowBoard();
    ShowInputOptions();
  while (true)
    {
    string input = GetInput();

    if (IsValidInput(input))
      {
        int position = GetPosition(input);
        
        if (IsPositionAvailable(position))
        {
          ProcessInput(position);
          UpdateGameState();

          if (IsGameOver())
        {
          ShowGameOverScreen();
          break;
        }

        ShowBoard();
        ShowInputOptions();
        }
        else
        {
          Console.WriteLine("That position is already taken!");
        }
      }
      else
      {
        Console.WriteLine("Invalid Input!");
      }
    }
  }
  public void Init()
  {
      for (int i = 0; i < board.Length; i++)
      {
        board[i] = (i + 1).ToString();
      }

      isPlayerOneTurn = true;
  }

  public void ShowBoard() 
  {
    Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
  }
  
  public void ShowInputOptions()
  {
    if (isPlayerOneTurn)
    {
      Console.WriteLine("Player one's turn.");
    }
    else
    {
      Console.WriteLine("Player two's turn.");
    }
  }

  public string GetInput()
  {
    return Console.ReadLine();
  }

  public bool IsValidInput(string input)
  {
    return input.Length == 1 &&
          input[0] >= '1' &&
          input[0] <= '9';
  }

  public int GetPosition(string input)
  {
    return int.Parse(input);
  }

  public void MakeMove(int position)
  {
    if (isPlayerOneTurn)
    {
      board[position - 1] = "X"; 
    }
    else
    {
      board[position - 1] = "O";
    }
  }

  public void ProcessInput(int position)
  {
    MakeMove(position);
  }

  public void SwitchTurn()
  {
    isPlayerOneTurn = !isPlayerOneTurn;
  }

  public void UpdateGameState()
  {
    SwitchTurn();
  }

  public bool IsGameOver()
  {
    return HasWinner() || IsBoardFull();
  }

  public bool Checkline(int a, int b, int c)
  {
    return board[a] == board[b] && 
          board[b] == board[c] &&
          (board[a] == "X" || board[a] == "O");
  }

  public void ShowGameOverScreen()
  {
    if (HasWinner())
    {
      Console.WriteLine($"{GetWinner()} wins!");
      ShowBoard();
    }
    else
    {
      Console.WriteLine("It's a draw!");
      ShowBoard();
    }
  }

  public bool IsPositionAvailable(int position)
  {
    return board[position - 1] != "X" &&
          board [position - 1] != "O";
  }

  public bool IsBoardFull()
  {
    for (int i = 0; i < board.Length; i++)
    {
      if (board[i] != "X" && board[i] != "O")
      {
        return false;
      }
    }
    return true;
  }

  public string GetWinner()
  {
    if (isPlayerOneTurn)
    {
      return "Player 2";
    }
    else
    {
      return "Player 1";
    }
  }

  public bool HasWinner()
  {
    if (Checkline(0, 1, 2) ||
        Checkline(3, 4, 5) ||
        Checkline(6, 7, 8) ||
        Checkline(0, 3, 6) ||
        Checkline(1, 4, 7) ||
        Checkline(2, 5, 8) ||
        Checkline(0, 4, 8) ||
        Checkline(2, 4, 6))
    {
      return true;
    }

    return false;
  }
}