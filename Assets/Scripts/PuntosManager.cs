using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public TextMeshProUGUI textodetiempo;
    float tiempo = 0f;
    public bool jugando = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jugando == true)
        {
        tiempo += Time.deltaTime;
        textodetiempo.text = "Tiempo: " + tiempo.ToString("F2") + "s";
        }
    }
}
