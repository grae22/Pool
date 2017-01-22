using NUnit.Framework;
using UnityEngine;
using GameLib.Tables;

namespace GameLib_Test.Tables
{
  class PoolTable_Test
  {
    //-------------------------------------------------------------------------

    private PoolTable TestObject;

    //-------------------------------------------------------------------------

    [SetUp]
    public void Initialise()
    {
      TestObject =
        new PoolTable(
          new Vector3( 1.0f, 0.0f, 1.5f ),
          new Vector3( 0.0f, 0.0f, 0.3f ),
          new Vector3( 0.0f, 0.0f, 1.0f ) );
    }

    //-------------------------------------------------------------------------

    [Test]
    public void Instantiate()
    {
      Assert.NotNull( TestObject );
    }

    //-------------------------------------------------------------------------
  }
}
