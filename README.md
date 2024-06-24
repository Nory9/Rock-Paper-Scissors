# Rock-Paper-Scissors Game

## Overview

This project is a simple console-based Rock-Paper-Scissors game where a player can compete against an AI. The game runs for three rounds, and the winner is determined based on the rules of Rock-Paper-Scissors.

## Features

- Play Rock-Paper-Scissors against an AI
- Three rounds per game
- Scores and winner are displayed at the end of each round and game
- Console-based user interface

## Technologies Used

- C#
- .NET Core
- xUnit (for unit testing)

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine

### Setup and Running the Game

1. **Clone the repository**:
   ```sh
   git clone https://github.com/Nory9/Rock-Paper-Scissors.git

2. **Navigate to the project directory:**
 ```sh
 cd Rock-Paper-Scissors
```

3. **Build the project:**
```sh  
dotnet build
```

4. **Run the game:**
```sh  
dotnet run --project Rock_Paper_Scissors
```




## Project Structure

- `Rock_Paper_Scissors` - Main project containing the game logic
    - `RPSGame.cs` - Main class handling the game flow and logic
    - `Player.cs` - Class representing a player
- `RockPaperScissors.Tests` - Test project containing unit tests
    - `RPSGameTests.cs` - Unit tests for the game logic using xUnit

## Game Instructions

1. **Start the game**: Run the project and follow the prompts in the console.
2. **Enter your name**: Provide your name to start the game.
3. **Play rounds**: For each round, enter your move (`Rock`, `Paper`, or `Scissors`).
4. **View results**: After each round, the scores are displayed. At the end of three rounds, the overall winner is announced.

## Running Unit Tests

To run the unit tests, use the following command:

```
dotnet test
```

The tests are written using xUnit and cover the core functionalities of the game.
