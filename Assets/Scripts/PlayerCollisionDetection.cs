using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
   void OnCollisionEnter(Collision colo)
   {
        if (colo.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
   }
}
