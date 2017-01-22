using UnityEngine;

namespace GameLib.Tables
{
  interface ITable : ITablePositions
  {
    //-------------------------------------------------------------------------

    Vector3 Dimensions { get; }

    //-------------------------------------------------------------------------
  }
}
