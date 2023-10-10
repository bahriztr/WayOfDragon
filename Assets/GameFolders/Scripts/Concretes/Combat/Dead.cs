using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Combats
{
    public class Dead : MonoBehaviour
    {
        [Header("Bools")]
        private bool _isDead;
        public bool IsDead => IsDead;

        public event System.Action OnDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }
    }
}

