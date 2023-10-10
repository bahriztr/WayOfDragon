using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] private GameObject persistantPrefab;

        private static bool _isFirstTime = true;

        private void Start()
        {
            if(_isFirstTime)
            {
                SpawnPersistentObject();
                _isFirstTime = false;
            }
        }

        private void SpawnPersistentObject()
        {
            GameObject newObject = Instantiate(persistantPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}

