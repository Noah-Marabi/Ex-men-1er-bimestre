using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCeros : MonoBehaviour
{
    public float dividendo;
    public float divisor;
    // Start is called before the first frame update
    void Start()
    {
        if(divisor== 0)
        {
            return;
        }
        else
        {
            Debug.Log(dividendo + " / " + divisor + " = " + (dividendo / divisor));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
