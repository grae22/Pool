using UnityEngine;

namespace GameLib.Tables
{
  class PoolTable : ITable
  {
    //-------------------------------------------------------------------------

    public Vector3 CueBallStartPosition { get; private set; }
    public Vector2 Dimensions { get; private set; }
    public Vector3 EightBallStartPosition { get; private set; }

    //-------------------------------------------------------------------------
  }
}