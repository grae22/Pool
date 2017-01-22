using UnityEngine;
using GameLib.Balls;
using GameLib.Tables;

public class BallSpawner : MonoBehaviour
{
  //---------------------------------------------------------------------------

  void Start()
  {
    IBallCollection balls;
    GameLib.Balls.BallSpawner.SpawnBalls( out balls );

    PoolTable table =
      new PoolTable(
        new Vector3( 1.0f, 0.0f, 1.5f ),
        new Vector3( 0.0f, 0.0f, 0.3f ),
        new Vector3( 0.0f, 0.0f, 1.0f ) );

    BallRacker.RackBalls( balls, table );
  }

  //---------------------------------------------------------------------------

  void Update()
  {

  }

  //---------------------------------------------------------------------------
}
