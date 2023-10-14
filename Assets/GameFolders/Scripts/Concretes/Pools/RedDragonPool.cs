using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstract.Pools;
using Controllers;

namespace Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
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

