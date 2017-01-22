using System.Collections.ObjectModel;

namespace GameLib.Balls
{
  public interface IBallCollection
  {
    //-------------------------------------------------------------------------

    ReadOnlyCollection< Ball > AllBalls { get; }

    //-------------------------------------------------------------------------

    Ball EightBall { get; }

    //-------------------------------------------------------------------------

    Ball CueBall { get; }

    //-------------------------------------------------------------------------
  }
}
