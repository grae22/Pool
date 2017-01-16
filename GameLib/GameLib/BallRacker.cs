using System;
using System.Collections.Generic;
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
      // Cue ball.
      if( balls.CueBall == null )
      {
        throw new Exception( "Null cue ball." );
      }

      balls.CueBall.Position = tablePositions.CueBallStartPosition;

      // Eight ball.
      if( balls.EightBall == null )
      {
        throw new Exception( "Null eight ball." );
      }

      balls.EightBall.Position = tablePositions.EightBallStartPosition;
    }

    //-------------------------------------------------------------------------
  }
}
