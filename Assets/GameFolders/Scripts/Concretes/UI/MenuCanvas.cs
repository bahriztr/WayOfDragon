using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class MenuCanvas : MonoBehaviour
    {
        public void ExitButtonClick()
        {
            GameManager.instance.ExitGame();
        }

        public void StartButtonClick()
        {
            GameManager.instance.StartGame();
        }
    }
}

