using System;
using UnityEngine;

namespace GameLib
{
  class BallRacker
  {
    //-------------------------------------------------------------------------

    public static void RackBalls(
      IBallCollection balls,
      ITablePositions tablePositions )
    {
      PlaceCueBall( balls, tablePositions );
      PlaceEightBall( balls, tablePositions );
    }

    //-------------------------------------------------------------------------

    private static void PlaceCueBall(
      IBallCollection balls,
      ITablePositions tablePositions )
    {
      if( balls.CueBall == null )
      {
        throw new Exception( "Null cue ball." );
      }

      balls.CueBall.Position = tablePositions.CueBallStartPosition;
    }

    //-------------------------------------------------------------------------

    private static void PlaceEightBall(
      IBallCollection balls,
      ITablePositions tablePositions )
    {
      if( balls.EightBall == null )
      {
        throw new Exception( "Null eight ball." );
      }

      balls.EightBall.Position = tablePositions.EightBallStartPosition;
    }

    //-------------------------------------------------------------------------
  }
}
