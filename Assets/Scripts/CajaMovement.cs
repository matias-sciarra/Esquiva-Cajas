using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float VelCaja = 0.1f;
    public float AumentoVelocidad = 0.1f;
    float initialYValue;
    // Start is called before the first frame update
    void Start()
    {
        initialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        VelCaja += AumentoVelocidad;
        transform.Translate(0, -VelCaja * Time.deltaTime, 0);
        
    }
    public void MoveBoxToRandomPosition()
    {
        //Para probar, solamete hacemos que suba
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}
