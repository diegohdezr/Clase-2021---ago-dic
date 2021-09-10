using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZig : Enemy
{

  
    public override void Move()
    {
        
        Vector3 tempPos = pos;
        tempPos.x = Mathf.Sin(Time.time * Mathf.PI * 2) * 4;
        pos = tempPos;//we use the pos propery from parent class enemy
        base.Move();//calls the normal functionallity from the parent class, with this you
                    //are combining behaviours
    }
    
}
