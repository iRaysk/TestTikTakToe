# Tic-Tac-Toe

A console-based Tic-Tac-Toe game built with C#.

## Features

- Two-player gameplay
- Player 1 uses `X`
- Player 2 uses `O`
- Input validation
- Prevents occupied positions from being selected
- Detects wins across rows, columns, and diagonals
- Detects draws
- Automatically switches turns

## How To Play

The game displays a 3x3 board with positions numbered from `1` to `9`.

    1 | 2 | 3
    ---------
    4 | 5 | 6
    ---------
    7 | 8 | 9

Players take turns entering the number of the position where they want to place their symbol.

The first player to get three of their symbols in a row, column, or diagonal wins.

If all nine positions are filled without a winner, the game ends in a draw.

## Installation

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download)

### Clone the repository

```bash
git clone https://github.com/iRaysk/TestTikTakToe.git
cd TestTikTakToe

## Run the Game

From the project directory, run:

dotnet run
```