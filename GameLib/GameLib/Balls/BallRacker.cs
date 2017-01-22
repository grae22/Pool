using System;
using UnityEngine;
using GameLib.Tables;

namespace GameLib.Balls
{
  public class BallRacker
  {
    //-------------------------------------------------------------------------

    // Relative to 8-ball position.
    private static readonly Vector3[] StartPositionOffsets =
    {
      new Vector3( 0.0f, 0.0f, -2.0f ),
      new Vector3( -0.5f, 0.0f, -1.0f ), new Vector3( 0.5f, 0.0f, -1.0f ),
      new Vector3( -1.0f, 0.0f, 0.0f ), new Vector3( 1.0f, 0.0f, 0.0f ),
      new Vector3( -1.5f, 0.0f, 1.0f ), new Vector3( -0.5f, 0.0f, 1.0f ), new Vector3( 0.5f, 0.0f, 1.0f ), new Vector3( 1.5f, 0.0f, 1.0f ),
      new Vector3( -2.0f, 0.0f, 2.0f ), new Vector3( -1.0f, 0.0f, 2.0f ), new Vector3( 0.0f, 0.0f, 2.0f ), new Vector3( 1.0f, 0.0f, 2.0f ), new Vector3( 2.0f, 0.0f, 2.0f )
    };

    private static readonly Vector3 RandomPositionOffsetMask = new Vector3( 1f, 0f, 1f );
    private static readonly float MaxRandomOffset = 0.005f;

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

      System.Random random = new System.Random();

      foreach( Ball ball in balls.AllBalls )
      {
        if( ball.IsCueBall ||
            ball.IsEightBall )
        {
          continue;
        }

        ball.Position = StartPositionOffsets[ ballPositionOffsetIndex++ ];
        ball.Position *= ball.Radius;
        ball.Position += tablePositions.EightBallStartPosition;

        Vector3 randomOffset =
          new Vector3(
            (float)random.NextDouble() * MaxRandomOffset,
            (float)random.NextDouble() * MaxRandomOffset,
            (float)random.NextDouble() * MaxRandomOffset );
        randomOffset = Vector2.Scale( randomOffset, RandomPositionOffsetMask );
        ball.Position += randomOffset;
      }
    }

    //-------------------------------------------------------------------------
  }
}
