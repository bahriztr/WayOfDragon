using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstract.Controllers;

namespace Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            ObstacleController enemy = collision.GetComponent<ObstacleController>();

            if(enemy != null)
            {
                GameManager.instance.IncreaseScore();
                enemy.KillGameObject();
            }

            KillGameObject();
        }

        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}

