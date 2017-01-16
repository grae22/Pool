using UnityEngine;

namespace GameLib
{
  interface ITablePositions
  {
    //-------------------------------------------------------------------------

    Vector3 CueBallStartPosition { get; }
    Vector3 EightBallStartPosition { get; }

    //-------------------------------------------------------------------------
  }
}
