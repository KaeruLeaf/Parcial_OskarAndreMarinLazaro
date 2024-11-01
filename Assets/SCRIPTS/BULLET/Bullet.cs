using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public RocksCounter rocksCounter;


    private void Start()
    {
        rocksCounter = FindObjectOfType<RocksCounter>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Rock"))
        {
            FindObjectOfType<SoundManager>().ReproducirSonidoColision();

            rocksCounter.IncrementarRock();

            Destroy(gameObject);
        }
    }
}
