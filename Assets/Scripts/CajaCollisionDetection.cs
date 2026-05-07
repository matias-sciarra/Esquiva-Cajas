using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;
     
    void Start()
    {
        cajaMovementScript = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision colo)
    {
        if (colo.gameObject.CompareTag("Suelo"))
        {
            cajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}
