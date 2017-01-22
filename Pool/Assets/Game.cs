using UnityEngine;
using GameLib.Balls;
using GameLib.Tables;

public class Game : MonoBehaviour
{
  //---------------------------------------------------------------------------

  private GameObject CueBall;

  //---------------------------------------------------------------------------

  void Start()
  {
    IBallCollection balls;
    BallSpawner.SpawnBalls( out balls );

    PoolTable table =
      new PoolTable(
        new Vector3( 1.0f, 0.0f, 1.5f ),
        new Vector3( 0.0f, 0.0f, 0.3f ),
        new Vector3( 0.0f, 0.0f, 1.0f ) );

    BallRacker.RackBalls( balls, table );

    foreach( Ball ball in balls.AllBalls )
    {
      CreateBall( ball );
    }

    CueBall.GetComponent< Rigidbody >().AddForce(
      new Vector3( 0f, 0f, 100f ) );
  }

  //---------------------------------------------------------------------------

  void Update()
  {

  }

  //---------------------------------------------------------------------------

  private void CreateBall( Ball ball )
  {
    GameObject gameObject =
      GameObject.CreatePrimitive(
        PrimitiveType.Sphere );

    gameObject.transform.localScale = new Vector3( ball.Radius, ball.Radius, ball.Radius );//.Set(
    gameObject.transform.position = ball.Position;

    Rigidbody rigidbody = gameObject.AddComponent< Rigidbody >();
    rigidbody.mass = ball.IsCueBall ? 0.17f : 0.16f;
    rigidbody.useGravity = false;
    rigidbody.drag = 0.5f;
    rigidbody.interpolation = RigidbodyInterpolation.Interpolate;

    if( ball.IsCueBall )
    {
      CueBall = gameObject;
    }
  }

  //---------------------------------------------------------------------------
}
