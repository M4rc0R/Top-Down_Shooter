using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyWithTime : MonoBehaviour
{

    public float BulletEnemyLifeTime;


 
    void Start()
    {
        Destroy(this.gameObject, BulletEnemyLifeTime);
    }

}
