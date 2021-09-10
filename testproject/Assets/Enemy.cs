using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public float speed = 10f;//speed in m/s
    private float firerate = 0.3f;//shots/second

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move() 
    {
        Vector3 tempPos =  pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        switch (other.tag) 
        {
            case "Hero":
                //nothing implemented yet
                break;
            case "HeroLaser":
                //destroy this enemy
                Destroy(this.gameObject);
                break;

        }
    }


    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }
}
