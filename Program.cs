using System;
using Chess;

namespace ChessBoard {

  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("What is the horizontal coordinate of your Queen?");
    int horizontalQueenCoordinate = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the vertical coordinate of your Queen?");
    int verticalQueenCoordinate = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the horizontal coordinate of your piece under attack?");
    int horizontalPieceCoordinate = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the vertical coordinate of your piece under atttack?");
    int verticalPieceCoordinate = int.Parse(Console.ReadLine());

    Queen q = new Queen(horizontalQueenCoordinate, verticalQueenCoordinate);

    Console.WriteLine(q.UnderAttack(horizontalPieceCoordinate, verticalPieceCoordinate));

    Console.WriteLine(" ________________");
    Console.WriteLine("|R N B K Q B N R|");
    Console.WriteLine("|P P P P P P P P|");
    Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~|");
    Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~|");
    Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~|");
    Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~|");
    Console.WriteLine("|P P P P P P P P|");
    Console.WriteLine("|R N B K Q B N R|");
    Console.WriteLine("L---------------⅃");
    }
  }
}