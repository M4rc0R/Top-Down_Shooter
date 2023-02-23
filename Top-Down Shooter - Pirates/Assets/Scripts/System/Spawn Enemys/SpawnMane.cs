using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMane : MonoBehaviour
{

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    [SerializeField] float enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        enemySpawn = float.Parse(ConfiEnemyChase.ChaseSpawn);
        InvokeRepeating("SpawnEnemys", enemySpawn, 10.0f);
        
    }


    void SpawnEnemys() {
        int index = Random.Range(0, spawnPoints.Length);
        
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
       

    }

   




}
