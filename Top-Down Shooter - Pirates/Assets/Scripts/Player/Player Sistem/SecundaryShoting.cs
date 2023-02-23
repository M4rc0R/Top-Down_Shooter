using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecundaryShoting : MonoBehaviour
{

    [SerializeField]
    private float SecundaryShootingSpeed;



    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * SecundaryShootingSpeed);
        StartCoroutine(destroyBullet());

    }


    IEnumerator destroyBullet()
    {


        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Enemy"))
        {

            Destroy(gameObject);
        }
    }
}
