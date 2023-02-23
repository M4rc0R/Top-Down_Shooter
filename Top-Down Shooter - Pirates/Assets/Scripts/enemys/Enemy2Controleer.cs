using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controleer : MonoBehaviour
{
    GameObject player;
    public GameObject healthBarObject;
    public float moveSpeed = 2.5f;
    public Transform healthBar;
    public int health;




    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private Transform explosionPosition;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector3 healthBarScale;
    private float healthBarPercent;


    





    
    
    
    
    private void Start()
    {

        //Inicializa o componente Rigidbody
        rb = this.GetComponent<Rigidbody2D>();

        //Determina que o objeto com a tag "Player" seja localizado
        player = GameObject.FindGameObjectWithTag("Player");

        //Inicia a barra de vida dos inimigos
        healthBarScale = healthBar.localScale;
        healthBarPercent = healthBarScale.x / health;


    
    }


    //Esta funcão é responsável por alterar os valores de dano de acordo com a variavel health
    void UpdateHealthBar() 
    {

        healthBarScale.x = healthBarPercent * health;
        healthBar.localScale = healthBarScale;

    }



    private void Update()
    {

        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        if (player == null) 
        {
            this.gameObject.SetActive(false);

        }

    }



    private void FixedUpdate()
    {

        MoveCharacter(movement);

    }



    void MoveCharacter(Vector2 direction)
    {

        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("bullet")) {
            health --;
            UpdateHealthBar();
            Instantiate(explosionEffect, explosionPosition.position, transform.rotation);

            if (health <= 0) {
                GameManager.Pontuacao++;
                Instantiate(explosionEffect, explosionPosition.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosionEffect, explosionPosition.position, transform.rotation);
            Destroy(gameObject);
        }

        
    }

    








}
