using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public TextMeshProUGUI textodepuntos;
    float puntos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos += 0.025f;
        textodepuntos.text = "puntos: " + puntos.ToString();
    }
}
