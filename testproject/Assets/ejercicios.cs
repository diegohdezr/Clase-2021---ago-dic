using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] nombres = new string[4] {"diego", "claudia", "liann", "roberto"};
        string[] apellidos = new string[5] {"quintana","heymann","gonzalez","martinez","hernandez" };
        string[] NyM = EncadenarArreglos(nombres, apellidos);
        foreach (string s in NyM)
        {
            Debug.Log(s);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //realiza una funcion que encadene 2 arreglos donde el arreglo1
    //tiene n posiciones y el arreglo2 tiene m posiciones

    //entradas: arr1, arr2, n, m
    //procesos: crear un arreglo arr3 de tamano n+m, copiar contenidos de arr1 y arr2 a arr3
    //salida: arr3

    public string[] EncadenarArreglos(string[] a, string[] b) 
    {
        string[] resultado = new string[a.Length+b.Length];
        int contador = 0;
        foreach (string s in a)
        {
            resultado[contador] = s;
            contador++;
        }
        foreach (string s in b)
        {
            resultado[contador] = s;
            contador++;
        }
        return resultado;
    }

}
