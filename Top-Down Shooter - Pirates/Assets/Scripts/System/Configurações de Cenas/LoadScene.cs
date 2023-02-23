using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadsScene(string nome) {

        SceneManager.LoadScene(nome);
    
    }

    public void ResetScene(string nome) {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
    }

    public void NextGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
    }

    public void FecharJogo() {

        Debug.Log("Fechou");
        Application.Quit();
    
    }


}
