using System;
using System.Diagnostics.Contracts;

public class TicTacToe
{
  string[] board = new string[9];
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
        MakeMove(position);
        SwitchTurn();
        ShowBoard();
        ShowInputOptions();
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
    board[position - 1] = "X";
  }

  public void ProcessInput(int position)
  {
    MakeMove(position);
  }

  public void SwitchTurn()
  {
    isPlayerOneTurn = !isPlayerOneTurn;
  }
}
