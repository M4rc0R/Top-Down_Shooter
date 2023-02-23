using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text textoPontuacao;
    public Text textoMelhorPontuacao;

    public void Exibir() 
    {
        this.gameObject.SetActive(true);
        this.textoPontuacao.text = (GameManager.Pontuacao + "x");
        this.textoMelhorPontuacao.text = GameManager.MelhorPontuacao.ToString();
        Time.timeScale = 0;
        
    }

    public void Esconder()
    {
        this.gameObject.SetActive(false);
        
    }

    public void TentarNovamente() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("game");
    }


    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }


}
