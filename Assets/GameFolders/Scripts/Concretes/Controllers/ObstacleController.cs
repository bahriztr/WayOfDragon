using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;
using Pools;

public class ObstacleController : Controllers.ObstacleController
{
    public override void SetEnemyPool()
    {
        ObstaclePool.instance.Set(this);
    }
}
