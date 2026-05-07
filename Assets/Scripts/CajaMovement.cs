using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float VelCaja = 0.1f;
    public
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -VelCaja * Time.deltaTime, 0);
        if (transform.position.y <= -0.5)
        {
            transform.Translate(0,9,0);
        }
    }
}
