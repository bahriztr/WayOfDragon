using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pools;

namespace Controllers
{
    public class RedDragonController : ObstacleController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.instance.Set(this);
        }
    }
}

