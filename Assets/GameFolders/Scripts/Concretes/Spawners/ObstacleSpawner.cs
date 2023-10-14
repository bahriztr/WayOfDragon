using System.Collections;
using System.Collections.Generic;
using Controllers;
using Abstract.Spawners;
using Pools;
using UnityEngine;

namespace Spawner
{
    public class ObstacleSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            Controllers.ObstacleController poolEnemy = ObstaclePool.instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }
}

