using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

    short a, b, c,d,e;
    public GameObject gameObjectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        string saludo = "hola como estas?";
        foreach (char c in saludo) {
            Debug.Log(c);
        }
        int l = saludo.Length;
        Debug.Log(l);




    }

    
    // Update is called once per frame
    void Update()
    {
        //Instantiate(gameObjectPrefab);
    }
}

public class Humano 
{
    public string nombre;
    public int edadEnMeses;
    int edadEnLustros;
    public string codigounicoregistropoblacional;
    public float estatura;
    public void CaminarDespacio(){
    
    }
    public void Dormir() {
        
    }

}
