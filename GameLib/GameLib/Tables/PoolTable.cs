using UnityEngine;

namespace GameLib.Tables
{
  class PoolTable : ITable
  {
    //-------------------------------------------------------------------------

    public Vector3 Dimensions { get; private set; }
    public Vector3 CueBallStartPosition { get; private set; }
    public Vector3 EightBallStartPosition { get; private set; }

    //-------------------------------------------------------------------------

    public PoolTable( 
      Vector3 dimensions,
      Vector3 cueBallStartPosition,
      Vector3 eightBallStartPosition )
    {
      Dimensions = dimensions;
      CueBallStartPosition = cueBallStartPosition;
      EightBallStartPosition = eightBallStartPosition;
    }

    //-------------------------------------------------------------------------
  }
}