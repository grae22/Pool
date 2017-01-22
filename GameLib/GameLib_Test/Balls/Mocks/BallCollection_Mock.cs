using System.Collections.Generic;
using System.Collections.ObjectModel;
using GameLib.Balls;

namespace GameLib_Test.Balls
{
  class BallCollection_Mock : IBallCollection
  {
    //-------------------------------------------------------------------------

    public ReadOnlyCollection< Ball > AllBalls { get; }

    //-------------------------------------------------------------------------

    public Ball CueBall { get; private set; }

    //-------------------------------------------------------------------------

    public Ball EightBall { get; private set; }

    //-------------------------------------------------------------------------

    public BallCollection_Mock(
      List< Ball > allBalls,
      Ball cueBall,
      Ball eightBall )
    {
      AllBalls = new ReadOnlyCollection< Ball >( allBalls );
      CueBall = cueBall;
      EightBall = eightBall;
    }

    //-------------------------------------------------------------------------

    public void ClearCueBall()
    {
      CueBall = null;
    }

    //-------------------------------------------------------------------------

    public void ClearEightBall()
    {
      EightBall = null;
    }

    //-------------------------------------------------------------------------
  }
}
