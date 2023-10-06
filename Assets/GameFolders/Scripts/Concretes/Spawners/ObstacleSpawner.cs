using System.Collections;
using System.Collections.Generic;
using Controllers;
using Abstract.Spawners;
using UnityEngine;

namespace Spawner
{
    public class ObstacleSpawner : BaseSpawner
    {
        [Space(3f)]
        [Header("Enemy")]
        [SerializeField] private EnemyController[] enemies;

        protected override void Spawn()
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], this.transform);
        }
    }
}

