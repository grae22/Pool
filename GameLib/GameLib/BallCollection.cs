using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameLib
{
  class BallCollection : IBallCollection
  {
    //-------------------------------------------------------------------------

    public ReadOnlyCollection< Ball > AllBalls { get; }

    //-------------------------------------------------------------------------

    public Ball CueBall { get; }

    //-------------------------------------------------------------------------

    public Ball EightBall { get; }

    //-------------------------------------------------------------------------

    public BallCollection(
      List< Ball > allBalls,
      Ball cueBall,
      Ball eightBall )
    {
      AllBalls = new ReadOnlyCollection< Ball >( allBalls );
      CueBall = cueBall;
      EightBall = eightBall;
    }

    //-------------------------------------------------------------------------
  }
}
