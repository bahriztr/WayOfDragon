using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.instance.RestartGame();
        }

        public void NoButtonClick()
        {
            Debug.Log("No Button Clicked.");
        }
    }
}

