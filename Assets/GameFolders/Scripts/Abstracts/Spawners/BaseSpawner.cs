using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstract.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Header("Timers For Spawn")]
        [Range(0.3f, 1.5f)]
        [SerializeField] private float minSpawnTime = 1f;
        [Range(2f, 5f)]
        [SerializeField] private float maxSpawnTime = 3f;

        private float _currentTime;
        private float _timeBoundary;

        private void Start()
        {
            ResetTimes();
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > _timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }

        protected abstract void Spawn();

        private void ResetTimes()
        {
            _currentTime = 0;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }

    }
}

