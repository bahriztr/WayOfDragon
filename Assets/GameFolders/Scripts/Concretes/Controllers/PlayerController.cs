using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Movements;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Instance Operations")]
        private Jump _jump;
        private PcInputController _input;

        [Header("Physic Components")]
        private Rigidbody2D _rb;

        [Header("Bools")]
        private bool _isLeftMouseClicked;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _input = new PcInputController();
        }

        private void Update()
        {
            InputProcess();
        }

        private void FixedUpdate()
        {
            JumpAction();
        }

        private void InputProcess()
        {
            if (_input.leftMouseClickDown)
                _isLeftMouseClicked = true;
        }

        private void JumpAction()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rb);

                _isLeftMouseClicked = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.instance.RestartGame();
        }
    }
}

