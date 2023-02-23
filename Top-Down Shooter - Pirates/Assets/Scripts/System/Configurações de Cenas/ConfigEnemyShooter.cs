using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigEnemyShooter : MonoBehaviour
{
    public static string ShooterSpawn;



    public void ReadStringInput(string tempoJogo)
    {
        ShooterSpawn = tempoJogo;


        Debug.Log(ShooterSpawn);
    }
}
