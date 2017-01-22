using NUnit.Framework;
using UnityEngine;
using GameLib.Balls;

namespace GameLib_Test.Balls
{
  [TestFixture]
  class Ball_Test
  {
    //-------------------------------------------------------------------------

    private const float BALL_RADIUS = 0.02f;
    private readonly Color BALL_COLOUR = Color.red;

    private Ball TestObject;

    //-------------------------------------------------------------------------

    [SetUp]
    public void Initialise()
    {
      TestObject =
        new Ball(
          BALL_RADIUS,
          BALL_COLOUR,
          false,
          false );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void Instantiate()
    {
      Assert.NotNull( TestObject );
      Assert.AreEqual( BALL_RADIUS, TestObject.Radius );
      Assert.IsFalse( TestObject.IsCueBall );
      Assert.IsFalse( TestObject.IsEightBall );
    }

    //-------------------------------------------------------------------------
  }
}
