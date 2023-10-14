using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [Header("Components")]
        private Rigidbody2D _rb;

        [Header("Values")]
        [SerializeField] private float moveSpeed = 5f;

        [Header("Enum")]
        [SerializeField] private DirectionEnum direction;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        void OnEnable()
        {
            MoveEnemy();
        }

        private void MoveEnemy()
        {
            _rb.velocity = SelectedDirection() * moveSpeed;
        }

        private Vector2 SelectedDirection()
        {
            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
                selectedDirection = Vector2.left;
            else
                selectedDirection = Vector2.right;

            return selectedDirection;
        }
    }
}
