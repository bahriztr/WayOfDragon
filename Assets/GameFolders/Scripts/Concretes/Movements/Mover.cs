using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [Header("Components")]
        private Rigidbody2D _rb;

        [Header("Values")]
        [SerializeField] private float moveSpeed = 5f;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        void Start()
        {
            MoveEnemy();
        }

        private void MoveEnemy()
        {
            _rb.velocity = Vector2.left * moveSpeed;
        }
    }
}
