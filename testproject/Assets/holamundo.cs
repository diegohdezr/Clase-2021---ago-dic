using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Hola mundo");
        print("hola desde print");
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        Debug.Log("Hola mundo"+contador);
    }
}
