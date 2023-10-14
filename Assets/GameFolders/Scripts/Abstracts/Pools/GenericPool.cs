using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Combats;

namespace Abstract.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {
        [Header("Prefabs")]
        [SerializeField] private T[] prefabs;

        [Header("Counts")]
        [SerializeField] private int countLoop = 5;

        [Header("Queue")]
        private Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake()
        {
            SingletonObject();
        }

        private void Start()
        {
            GrowPoolPrefab();
        }

        private void OnEnable()
        {
            GameManager.instance.OnSceneChanged += ResetAllObjects;
        }

        private void OnDisable()
        {
            GameManager.instance.OnSceneChanged -= ResetAllObjects;
        }

        protected abstract void SingletonObject();

        public T Get()
        {
            if (_poolPrefabs.Count == 0)
                GrowPoolPrefab();

            return _poolPrefabs.Dequeue();
        }

        public abstract void ResetAllObjects();

        private void GrowPoolPrefab()
        {
            for(int i = 0; i < countLoop; i++)
            {
                T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }
        }

        public void Set(T poolObject)
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }
    }
}

