using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountItHigher : MonoBehaviour
{

    private int _num = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(nextNum);
    }

    public int nextNum 
    {
        get
        {
            _num++;
            return (_num);
        }
        //nextNum is a property that is read-only.
        //Because there is no set{} clause, it can only be read (e.g., int x = nextNum;)
        //and cannot be set (e.g., nextNum = 5; would cause an error).

        
    }
    public int currentNum
    {
        get { return (_num); }
        set { _num = value; }
    }
}
