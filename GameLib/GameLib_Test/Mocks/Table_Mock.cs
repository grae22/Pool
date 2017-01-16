using UnityEngine;
using GameLib;

namespace GameLib_Test.Mocks
{
  class Table_Mock : ITablePositions
  {
    //-------------------------------------------------------------------------

    public Vector3 CueBallStartPosition
    {
      get
      {
        return new Vector3();
      }
    }

    //-------------------------------------------------------------------------

    public Vector3 EightBallStartPosition
    {
      get
      {
        return new Vector3( 0, 0, 1f );
      }
    }

    //-------------------------------------------------------------------------
  }
}
