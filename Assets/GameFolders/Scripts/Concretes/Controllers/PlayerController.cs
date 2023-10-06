using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Movements;
using Combats;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Instance Operations")]
        private Jump _jump;
        private PcInputController _input;
        private LaunchProjectile _launchProjectile;

        [Header("Physic Components")]
        private Rigidbody2D _rb;

        [Header("Bools")]
        private bool _isLeftMouseClicked;
        private bool _isRightMouseClicked;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _input = new PcInputController();
        }

        private void Update()
        {
            InputProcess();
        }

        private void FixedUpdate()
        {
            JumpAction();
            LaunchAction();
        }

        private void InputProcess()
        {
            if (_input.leftMouseClickDown)
                _isLeftMouseClicked = true;

            if (_input.rightMouseClickDown)
                _isRightMouseClicked = true;
        }

        private void JumpAction()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rb);

                _isLeftMouseClicked = false;
            }
        }

        private void LaunchAction()
        {
            if (_isRightMouseClicked)
            {
                _launchProjectile.LaunchAction();

                _isRightMouseClicked = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.instance.RestartGame();
        }
    }
}

