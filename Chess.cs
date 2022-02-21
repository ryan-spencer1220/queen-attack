using System;

namespace Chess {
  public class Queen
  {
    public int _horizontal;
    public int _vertical;

    public Queen(int horizontal, int vertical)
    {
      _horizontal = horizontal;
      _vertical = vertical;
    }
    public bool UnderAttack(int otherPieceX, int otherPieceY)
    {
      if (_horizontal == otherPieceX && _vertical == otherPieceY)
      {
        return false;
      }
      else if (_horizontal == otherPieceX || _vertical == otherPieceY)
      {
        return true;
      }
      else if (Math.Abs(_horizontal - otherPieceX) == Math.Abs(_vertical - otherPieceY))
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}