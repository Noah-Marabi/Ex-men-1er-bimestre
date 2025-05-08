using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptNumeroMayor : MonoBehaviour
{
    public int numero1;
    public int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < numero2)
        {
            Debug.Log("El mayor de los dos números entregados es " + numero2);
        }
        else if(numero1>numero2)
        {
            Debug.Log("El mayor de los dos números entregados es " + numero1);
        }
        else if (numero1 == numero2)
        {
            Debug.Log("Los dos números son iguales");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
