using NUnit.Framework;
using GameLib.Balls;

namespace GameLib_Test
{
  [TestFixture]
  class BallSpawner_Test
  {
    //---------------------------------------------------------------------------

    [Test]
    public void SpawnBalls()
    {
      IBallCollection balls;
      BallSpawner.SpawnBalls( out balls );

      Assert.AreEqual( 16, balls.AllBalls.Count );
      Assert.NotNull( balls.CueBall );
      Assert.NotNull( balls.EightBall );
    }

    //---------------------------------------------------------------------------
  }
}
