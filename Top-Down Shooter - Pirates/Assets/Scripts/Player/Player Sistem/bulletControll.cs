using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControll : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] ParticleSystem effect;
    [SerializeField] private GameObject explosingEffect;
    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        StartCoroutine(destroyBullet());
        
    }


    IEnumerator destroyBullet() {


        yield return new WaitForSeconds(0.5f);
        Instantiate(explosingEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Enemy")) {
            Instantiate(explosingEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
