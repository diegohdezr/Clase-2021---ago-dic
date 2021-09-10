using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionesPrueba : MonoBehaviour
{
    //crea una funcion que sume dos numeros enteros y regrese el resultado como entero
    //entradas: 2 numeros
    //procesos: una suma
    //salidas: el resultado de la suma

    //crea una funcion que reciba una lista de numeros y te regrese el promedio de los numeros
    //entradas: la lista de los numeros
    //procesos: suma de numeros, tamano de la lista, dividir la suma entre tamano de la lista
    //salida: resultado

    
    protected int variablePublica = 0;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        int a, b, c, d, e;
        a = 5;
        b = 7;
        c = 5;
        d = 9;
        e = 198;
        List<int> numeros = new List<int>();
        numeros.Add(a);
        numeros.Add(b);
        numeros.Add(c);
        numeros.Add(d);
        numeros.Add(e);
        
        int resultado = 0;
        string g = "5";
        byte f = 198;
        float h = 55.3432523f;
      
        resultado = sumar(f, e);
        resultado = sumar(a, b);
        resultado = sumar(a, b, d);
        resultado = multiplicar(e, a);
        resultado = Convert.ToInt32( dividir(a,f));

        h = promediar(numeros);
        Debug.Log("fin de las operaciones");

    }

    // Update is called once per frame
    void Update()
    {
        //contador++;
        //contarframes();
    }

    float factorial(float a) 
    {
        if (a < 0) return (0);
        if (a == 0) return (1);
        float resultado = a * factorial(a-1);
        return (resultado);

    }

    private void contarframes()
    {
        Debug.Log("llevamos " + contador + "frames ejecutados");
        return;
    }

    int sumar(int a, int b) 
    {
        Debug.Log(a + b);
        return (a + b);
        Debug.Log("esto va debajo del return");
    }
    int sumar(int a, int b, int c) 
    {
        Debug.Log(a + b + c);
        return (a + b + c);
    }

    int multiplicar(int a, int b) 
    {
        Debug.Log(a * b);
        return (a * b);

    }
    int dividir(int dividendo, int divisor = 1 ) 
    {
        return (dividendo / divisor);
    }
    float dividir2(float dividendo, float divisor = 1)
    {
        return (dividendo / divisor);
    }

    //crea una funcion que reciba una lista de numeros y te regrese el promedio de los numeros
    //entradas: la lista de los numeros
    //procesos: suma de numeros, tamano de la lista, dividir la suma entre tamano de la lista
    //salida: resultado
    float promediar(List<int> numeros)
    {
        float suma = 0;
        foreach (int numero in numeros)
        {
            suma = suma + numero;
        }

        float resultado = suma / numeros.Count;
        return (resultado);
    }

}
