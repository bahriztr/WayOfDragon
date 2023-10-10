using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.instance.StartGame();
        }

        public void NoButtonClick()
        {
            GameManager.instance.ReturnMenu();
        }
    }
}

