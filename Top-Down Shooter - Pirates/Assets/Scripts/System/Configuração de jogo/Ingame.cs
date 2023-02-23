using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingame : MonoBehaviour
{

    public Text textoPontuacao;

    void Update()
    {
        this.textoPontuacao.text = (GameManager.Pontuacao + "x");
    }
}
