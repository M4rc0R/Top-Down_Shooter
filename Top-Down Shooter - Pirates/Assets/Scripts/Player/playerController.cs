using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{

    public GameObject bullet, spawerbullet;
    public GameObject SecundaryBullet, spawerSecundaryBullet;
    public GameObject SecundaryBullet3, spawerSecundaryBullet3;
    public GameObject healthBarObject;

    public Transform healthBar;
    public Rigidbody2D rb;
    public float speed;
    public int health;


    private Vector2 movement;
    private Vector3 healthBarScale;
    private float healthBarPercent;
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private Transform explosionPosition;

    private GameOver telaFimJogo;






    private void Start()
    {
        healthBarScale = healthBar.localScale;
        healthBarPercent = healthBarScale.x / health;


        GameObject fimJogoGameObject = GameObject.FindGameObjectWithTag("TelaFimJogo");
        this.telaFimJogo = fimJogoGameObject.GetComponent<GameOver>();
        this.telaFimJogo.Esconder();

    }




    void UpdateHealthBar()
    {

        healthBarScale.x = healthBarPercent * health;
        healthBar.localScale = healthBarScale;

    }



    private void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        movement = new Vector2(moveX, moveY);


        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);


        Vector3 mousePos = Input.mousePosition;


        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);


        transform.up = direction;


        if (Input.GetMouseButtonDown(0)) 
        {

            Instantiate(bullet, spawerbullet.transform.position, this.gameObject.transform.rotation);

        }

        if (Input.GetButtonDown("Jump")) 
        {

            Instantiate(SecundaryBullet, spawerSecundaryBullet.transform.position, this.gameObject.transform.rotation);
            Instantiate(SecundaryBullet, spawerSecundaryBullet.transform.position, this.gameObject.transform.rotation);
            Instantiate(SecundaryBullet, spawerSecundaryBullet.transform.position, this.gameObject.transform.rotation);


        }
        
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            health --;
            UpdateHealthBar();
            

            if (health == 0) 
            {
                this.gameObject.SetActive(false);
                Destroy(gameObject);
                
                telaFimJogo.Exibir();
                
            }

        }

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {

            health --;
            UpdateHealthBar();

            if (health == 0)
            {

                this.gameObject.SetActive(false);
                Destroy(gameObject);
                
                telaFimJogo.Exibir();

            }

        }

    }

}
