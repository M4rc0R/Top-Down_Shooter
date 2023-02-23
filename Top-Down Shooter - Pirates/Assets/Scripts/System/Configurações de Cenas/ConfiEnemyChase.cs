using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiEnemyChase : MonoBehaviour
{
    public static string ChaseSpawn;



    public void ReadStringInput(string tempoJogo)
    {
        ChaseSpawn = tempoJogo;

        
        Debug.Log(ChaseSpawn);
    }
}
