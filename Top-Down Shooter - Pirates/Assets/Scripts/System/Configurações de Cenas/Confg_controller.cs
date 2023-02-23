using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confg_controller : MonoBehaviour
{
    public static string input;

   

    public void ReadStringInput(string tempoJogo) 
    {
        input = tempoJogo;

        if (tempoJogo == string.Empty) 
        {
            input = "60";
        }
        Debug.Log(input);
    }








}
