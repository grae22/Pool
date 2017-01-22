using System;
using UnityEngine;
using GameLib.Tables;

namespace GameLib.Balls
{
  public class BallRacker
  {
    //-------------------------------------------------------------------------

    // Relative to 8-ball position.
    private static readonly Vector2[] StartPositionOffsets =
    {
      new Vector2( 0.0f, -2.0f ),
      new Vector2( -0.5f, -1.0f ), new Vector2( 0.5f, -1.0f ),
      new Vector2( -1.0f, 0.0f ), new Vector2( 1.0f, 0.0f ),
      new Vector2( -1.5f, 1.0f ), new Vector2( -0.5f, 1.0f ), new Vector2( 0.5f, 1.0f ), new Vector2( 1.5f, 1.0f ),
      new Vector2( -2.0f, 2.0f ), new Vector2( -1.0f, 2.0f ), new Vector2( 0.0f, 2.0f ), new Vector2( 1.0f, 2.0f ), new Vector2( 2.0f, 2.0f )
    };

    //-------------------------------------------------------------------------

    public static void RackBalls(
      IBallCollection balls,
      ITablePositions tablePositions )
    {
      PlaceCueBall( balls, tablePositions );
      PlaceEightBall( balls, tablePositions );
      PlaceGeneralBalls( balls, tablePositions );
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

    private static void PlaceGeneralBalls(
      IBallCollection balls,
      ITablePositions tablePositions )
    {
      int ballPositionOffsetIndex = 0;

      foreach( Ball ball in balls.AllBalls )
      {
        if( ball.IsCueBall ||
            ball.IsEightBall )
        {
          continue;
        }

        ball.Position =
          StartPositionOffsets[ ballPositionOffsetIndex++ ] * ball.Radius;
      }
    }

    //-------------------------------------------------------------------------
  }
}
