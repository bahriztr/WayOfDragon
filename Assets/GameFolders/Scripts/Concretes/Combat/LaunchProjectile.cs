using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;

namespace Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [Header("Projectile Attributes")]
        [SerializeField] private ProjectileController projectilePrefab;
        [SerializeField] private Transform projectileTransform;
        [SerializeField] private Transform projectileParent;

        [Header("Projectile Timers")]
        [SerializeField] private float delayProjectile = 1f;
        private float _currentDelayTime = 1;
        private bool _canLaunch;

        private void Update()
        {
            LaunchTimer();
        }

        private void LaunchTimer()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if(_canLaunch)
            {
                ProjectileController newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.rotation);
                newProjectile.transform.parent = projectileParent;
                _canLaunch = false;
            }
        }
    }
}

