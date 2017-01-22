using UnityEngine;

namespace GameLib.Tables
{
  interface ITable : ITablePositions
  {
    //-------------------------------------------------------------------------

    Vector2 Dimensions { get; }

    //-------------------------------------------------------------------------
  }
}
