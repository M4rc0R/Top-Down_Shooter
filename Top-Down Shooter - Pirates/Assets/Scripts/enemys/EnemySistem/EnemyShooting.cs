using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;
    
    private float timer;



    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            timer = 0;
            Shooting();
        
        }
    }

    void Shooting() {

        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
