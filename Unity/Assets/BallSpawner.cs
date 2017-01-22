using UnityEngine;
using GameLib;

public class BallSpawner : MonoBehaviour
{
  //---------------------------------------------------------------------------

  void Start()
  {
    IBallCollection balls;
    GameLib.BallSpawner.SpawnBalls( out balls );

    BallRacker.RackBalls( balls, table );
  }

  //---------------------------------------------------------------------------

  void Update()
  {

  }

  //---------------------------------------------------------------------------
}
