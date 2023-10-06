using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;
using Abstract.Spawners;

public class RedDragonSpawner : BaseSpawner
{
    [Space(3f)]
    [Header("Enemy")]
    [SerializeField] private EnemyController enemy;

    protected override void Spawn()
    {
        Instantiate(enemy, this.transform);
    }
}
