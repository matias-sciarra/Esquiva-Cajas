using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    public PuntosManager puntosmanagereados;
   void OnCollisionEnter(Collision colo)
   {
        if (colo.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
            puntosmanagereados.jugando = false;
        }
   }
}
