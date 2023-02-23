using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShooting : MonoBehaviour
{

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    [SerializeField] float shootingEnemy;

    // Start is called before the first frame update
    void Start()
    {
        shootingEnemy = float.Parse(ConfigEnemyShooter.ShooterSpawn);

        InvokeRepeating("SpawnEnemys", shootingEnemy, 15.0f);

    }


    void SpawnEnemys()
    {
        int index = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);


    }

}
