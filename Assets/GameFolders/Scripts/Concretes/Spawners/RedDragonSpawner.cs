using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;
using Abstract.Spawners;
using Pools;

public class RedDragonSpawner : BaseSpawner
{
    [Space(3f)]
    [Header("Enemy")]
    [SerializeField] private Controllers.ObstacleController enemy;

    protected override void Spawn()
    {
        Controllers.ObstacleController newEnemy = RedDragonPool.instance.Get();
        newEnemy.transform.position = this.transform.position;
        newEnemy.gameObject.SetActive(true);
    }
}
