using System;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using UnityEngine;
using GameLib.Balls;
using GameLib.Tables;

namespace GameLib_Test.Balls
{
  [TestFixture]
  class BallRacker_Test
  {
    //-------------------------------------------------------------------------

    private IBallCollection Balls;
    private Mock< ITablePositions > Table;

    //-------------------------------------------------------------------------

    [SetUp]
    public void Initialise()
    {
      Table = new Mock< ITablePositions >();
      Table.SetupGet( m => m.CueBallStartPosition ).Returns( new Vector3() );
      Table.SetupGet( m => m.CueBallStartPosition ).Returns( new Vector3( 0f, 0f, 1f ) );

      BallSpawner.SpawnBalls( out Balls );
      BallRacker.RackBalls( Balls, Table.Object );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void CueBallPosition()
    {
      Assert.AreEqual(
        Table.Object.CueBallStartPosition,
        Balls.CueBall.Position );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void EightBallPosition()
    {
      Assert.AreEqual(
        Table.Object.EightBallStartPosition,
        Balls.EightBall.Position );
    }

    //-------------------------------------------------------------------------
    
    [Test]
    public void OtherBalls()
    {
      foreach( Ball ball in Balls.AllBalls )
      {
        if( ball.IsCueBall == false &&
            ball.IsEightBall == false )
        {
          Assert.Greater(
            ball.Position.magnitude,
            0f );
        }
      }
    }

    //-------------------------------------------------------------------------

    [Test]
    public void HandleNullCueBall()
    {
      BallCollection balls =
        new BallCollection(
          new List< Ball >(),
          null,
          new Ball( 1f, Color.black, false, true ) );

      Assert.That(
        () =>
          BallRacker.RackBalls( balls, Table.Object ),
          Throws.TypeOf< Exception >()
            .With.Message.EqualTo( "Null cue ball." ) );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void HandleNullEightBall()
    {
      BallCollection balls =
        new BallCollection(
          new List< Ball >(),
          new Ball( 1f, Color.white, true, false ),
          null );

      Assert.That(
        () =>
          BallRacker.RackBalls( balls, Table.Object ),
          Throws.TypeOf< Exception >()
            .With.Message.EqualTo( "Null eight ball." ) );
    }

    //-------------------------------------------------------------------------
  }
}
