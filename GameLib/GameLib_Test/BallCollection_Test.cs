using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using GameLib.Balls;

namespace GameLib_Test
{
  [TestFixture]
  class BallCollection_Test
  {
    //-------------------------------------------------------------------------

    private BallCollection TestObject;
    private List< Ball > AllBalls;
    private Ball CueBall;
    private Ball EightBall;

    //-------------------------------------------------------------------------

    [SetUp]
    public void Initialise()
    {
      // Create some balls.
      AllBalls = new List< Ball >();
      AllBalls.Add( new Ball( 1f, Color.red, false, false ) );
      AllBalls.Add( new Ball( 1f, Color.yellow, false, false ) );

      // Create cue & eight balls.
      CueBall = new Ball( 1f, Color.white, true, false );
      AllBalls.Add( CueBall );

      EightBall = new Ball( 1f, Color.black, false, true );
      AllBalls.Add( EightBall );

      // Create test object.
      TestObject =
        new BallCollection(
          AllBalls,
          CueBall,
          EightBall );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void ContainsAllBalls()
    {
      foreach( Ball ball in AllBalls )
      {
        Assert.True( TestObject.AllBalls.Contains( ball ) );
      }
    }

    //-------------------------------------------------------------------------

    [Test]
    public void ContainsCueBall()
    {
      Assert.True( TestObject.AllBalls.Contains( CueBall ) );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void ContainsEightBall()
    {
      Assert.True( TestObject.AllBalls.Contains( EightBall ) );
    }

    //-------------------------------------------------------------------------
  }
}
