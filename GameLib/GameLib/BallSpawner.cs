using System.Collections.Generic;
using UnityEngine;

namespace GameLib
{
  class BallSpawner
  {
    //---------------------------------------------------------------------------

    private static readonly float BALL_RADIUS = 0.027f;
    private static readonly Color BALL_COLOUR_1 = Color.red;
    private static readonly Color BALL_COLOUR_2 = Color.yellow;
    private static readonly Color CUE_BALL_COLOUR = Color.white;
    private static readonly Color EIGHT_BALL_COLOUR = Color.black;

    //---------------------------------------------------------------------------

    public static void SpawnBalls( out IBallCollection balls )
    {
      // Create the balls.
      List< Ball > allBalls = new List< Ball >();

      CreateColouredBalls(
        allBalls,
        7,
        BALL_COLOUR_1 );

      CreateColouredBalls(
        allBalls,
        7,
        BALL_COLOUR_2 );

      Ball cueBall = CreateCueBall();
      allBalls.Add( cueBall );

      Ball eightBall = CreateEightBall();
      allBalls.Add( eightBall );

      // Create the collection.
      balls =
        new BallCollection(
          allBalls,
          cueBall,
          eightBall );
    }

    //---------------------------------------------------------------------------

    static void CreateColouredBalls(
      List< Ball > balls,
      int count,
      Color colour )
    {
      for( int i = 0; i < count; i++ )
      {
        balls.Add(
          new Ball(
            BALL_RADIUS,
            colour,
            false,
            false ) );
      }
    }

    //---------------------------------------------------------------------------

    static Ball CreateCueBall()
    {
      return
        new Ball(
          BALL_RADIUS, 
          CUE_BALL_COLOUR,
          true, 
          false );
    }

    //---------------------------------------------------------------------------

    static Ball CreateEightBall()
    {
      return
        new Ball(
          BALL_RADIUS,
          EIGHT_BALL_COLOUR,
          false,
          true );
    }

    //---------------------------------------------------------------------------
  }
}
