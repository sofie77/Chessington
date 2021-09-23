using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;



            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col + i);
                availableSquares.Add(newPosition);
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col - i);
                availableSquares.Add(newPosition);
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col + i);
                availableSquares.Add(newPosition);
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col - i);
                availableSquares.Add(newPosition);
            }

            return availableSquares;
        }
    }
}