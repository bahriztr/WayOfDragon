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
            EnemyController enemy = collision.GetComponent<EnemyController>();

            if(enemy != null)
            {
                GameManager.instance.IncreaseScore();
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}

