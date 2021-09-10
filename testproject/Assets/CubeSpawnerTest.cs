using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerTest : MonoBehaviour
{

    public GameObject           cubePrefab;
    public List<GameObject>     gameObjectList;
    public float                scalingFactor = 0.95f;
    public int                  numCubes = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectList = new List<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubes++;
        GameObject gObj = Instantiate<GameObject>(cubePrefab);
        gObj.name = "Cube " + numCubes;
        Color c = new Color(Random.value, Random.value, Random.value);
        gObj.GetComponent<Renderer>().material.color = c;
        gObj.transform.position = Random.insideUnitSphere;

        gameObjectList.Add(gObj);

        List<GameObject> removeList = new List<GameObject>();
        foreach (GameObject gOTemp in gameObjectList)
        {
            float scale = gOTemp.transform.localScale.x;
            scale *= scalingFactor;
            gOTemp.transform.localScale = Vector3.one * scale;
        
            if (scale <= 0.1f) 
            {
                removeList.Add(gOTemp);
            }
        }

        foreach (GameObject gOTemp in removeList)
        {
            gameObjectList.Remove(gOTemp);
            Destroy(gOTemp);
        }
    
            
            
    }
}
