using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square newPosition;



            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col + i);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col - i);
                
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col + i);
                
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col - i);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for(int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row + i, currentPosition.Col);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row - i, currentPosition.Col);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row, currentPosition.Col + i);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                newPosition = Square.At(currentPosition.Row, currentPosition.Col - i);
                if (newPosition.Row >= 0 && newPosition.Row <= 7 && newPosition.Col >= 0 && newPosition.Col <= 7)
                {
                    availableSquares.Add(newPosition);
                }
            }

            return availableSquares;
        }
    }
}