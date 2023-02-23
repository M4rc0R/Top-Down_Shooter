using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    
    public Image timer_linear_image;
    public float time_remainning;
    private float max_time;
    private GameWin telaFimJogo;



    // Start is called before the first frame update
    void Start()
    {
        max_time = float.Parse(Confg_controller.input);
        time_remainning = max_time;
        GameObject fimJogoGameObject = GameObject.FindGameObjectWithTag("TelaFimJogo");
        this.telaFimJogo = fimJogoGameObject.GetComponent<GameWin>();
        this.telaFimJogo.Esconder();
    }

    // Update is called once per frame
    void Update()
    {
        if (time_remainning > 0)
        {

            time_remainning -= Time.deltaTime;
            timer_linear_image.fillAmount = time_remainning / max_time;


        }
        else {

            telaFimJogo.Exibir(); 
        
        }
        
    }
}
