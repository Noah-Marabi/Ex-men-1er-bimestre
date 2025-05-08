using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPalabra : MonoBehaviour
{
    string palabra = "domingo";
    public string palabraIngresada;
    // Start is called before the first frame update
    void Start()
    {
        if(palabraIngresada == palabra)
        {
            Debug.Log("Has adivinado la palabra");
        }
        else
        {
            Debug.Log("Palabra incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
