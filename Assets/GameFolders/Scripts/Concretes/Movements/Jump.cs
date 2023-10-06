using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movements
{
    public class Jump : MonoBehaviour
    {
        [Header("Jump Attribute")]
        [SerializeField] private float jumpForce;

        public void JumpAction(Rigidbody2D rb)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}

