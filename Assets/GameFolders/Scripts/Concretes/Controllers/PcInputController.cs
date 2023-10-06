using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class PcInputController
    {
        public bool leftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool rightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}

