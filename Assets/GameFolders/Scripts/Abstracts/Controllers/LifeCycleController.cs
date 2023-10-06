using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstract.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [Header("Timer")]
        [SerializeField] private float maxLifeTime = 5f;
        private float _currentTime;

        void Update()
        {
            _currentTime += Time.deltaTime;

            DestroyCondition();
        }

        private void DestroyCondition()
        {
            if (_currentTime >= maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

