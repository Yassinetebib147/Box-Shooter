using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeGameOver : MonoBehaviour
{
   
    void OnCollisionEnter(Collision newCollision)
    {
        if (newCollision.gameObject.tag == "Player")
        {
            // if game manager exists, make adjustments based on target properties
            if (GameManager.gm)
            {
                GameManager.gm.gameIsOver = true ;
            }

        }
        // destroy the projectile
        Destroy(newCollision.gameObject);

    }
}
