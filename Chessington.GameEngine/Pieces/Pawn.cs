﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            //whats this 
            //return Enumerable.Empty<Square>();
            //var myEnumerable = new List<Square>();


            Square newPosition;
            

            // find current location

            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            if (Player == Player.White)
            {
               
                //find square one up from it (which is 1 less in y co-ordinate
                newPosition = Square.At(currentPosition.Row - 1, currentPosition.Col);
                //put that square in a list
                availableSquares.Add(newPosition);

            }
            else
            {
                //find square one up from it (which is 1 less in y co-ordinate
                newPosition = Square.At(currentPosition.Row + 1, currentPosition.Col);
                //put that square in a list
                availableSquares.Add(newPosition);


            }
            return availableSquares;

        

        }
    }
}