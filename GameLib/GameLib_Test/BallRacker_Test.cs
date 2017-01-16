using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using GameLib;
using GameLib_Test.Mocks;

namespace GameLib_Test
{
  [TestFixture]
  class BallRacker_Test
  {
    //-------------------------------------------------------------------------

    private IBallCollection Balls;
    private Table_Mock Table;

    //-------------------------------------------------------------------------

    [SetUp]
    public void Initialise()
    {
      Table = new Table_Mock();

      BallSpawner.SpawnBalls( out Balls );
      BallRacker.RackBalls( Balls, Table );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void CueBallPosition()
    {
      Assert.AreEqual(
        Table.CueBallStartPosition,
        Balls.CueBall.Position );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void EightBallPosition()
    {
      Assert.AreEqual(
        Table.EightBallStartPosition,
        Balls.EightBall.Position );
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
          BallRacker.RackBalls( balls, Table ),
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
          BallRacker.RackBalls( balls, Table ),
          Throws.TypeOf< Exception >()
            .With.Message.EqualTo( "Null eight ball." ) );
    }

    //-------------------------------------------------------------------------
  }
}
