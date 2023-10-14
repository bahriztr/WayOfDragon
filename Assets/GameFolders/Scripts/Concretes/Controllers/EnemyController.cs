using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstract.Controllers;
using Pools;

namespace Controllers
{
    public abstract class ObstacleController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}
