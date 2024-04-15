using System;

class Program {
  public static void Main (string[] args) {

    Player playerObject = new Player();
    Player enemyObject = new Player();

    playerObject.Level = 1;
    enemyObject.Level = 100;

    Console.WriteLine (playerObject.Level);
    Console.WriteLine (enemyObject.Level);
    Console.WriteLine (playerObject.JoinedGame);
    Console.WriteLine (enemyObject.JoinedGame);
  }
}