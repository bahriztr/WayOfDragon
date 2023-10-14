using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstract.Pools;
using Controllers;

namespace Pools
{
    public class ObstaclePool : GenericPool<ObstacleController>
    {
        public static ObstaclePool instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach(ObstacleController child in GetComponentsInChildren<ObstacleController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.KillGameObject();
            }
        }

        protected override void SingletonObject()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }

            else
                Destroy(this.gameObject);
        }
    }
}

