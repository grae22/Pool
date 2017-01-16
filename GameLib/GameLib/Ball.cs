using UnityEngine;

namespace GameLib
{
  public class Ball : IColouredBall
  {
    //-------------------------------------------------------------------------

    public float Radius { get; private set; }
    public Color Colour { get; private set; }
    public Vector3 Position { get; set; }
    public bool IsCueBall { get; private set; }
    public bool IsEightBall { get; private set; }

    //-------------------------------------------------------------------------

    public Ball(
      float radius,
      Color colour,
      bool isCueBall,
      bool isEightBall )
    {
      Radius = radius;
      Colour = colour;
      IsCueBall = isCueBall;
      IsEightBall = isEightBall;
    }

    //-------------------------------------------------------------------------
  }
}
