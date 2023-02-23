using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyController : MonoBehaviour
{
    public float shootingSpeed;

    private GameObject player;

    [SerializeField]
   
    private Rigidbody2D rb;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;

        rb.velocity = new Vector2(direction.x, direction.y).normalized * shootingSpeed;

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player")) {

            Destroy(gameObject);
        }
    }

}
