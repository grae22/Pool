using UnityEngine;

namespace GameLib.Tables
{
  public interface ITablePositions
  {
    //-------------------------------------------------------------------------

    Vector3 CueBallStartPosition { get; }
    Vector3 EightBallStartPosition { get; }

    //-------------------------------------------------------------------------
  }
}
