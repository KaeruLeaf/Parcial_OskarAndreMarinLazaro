using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform balaPrefab;

    public Transform shootPoint;

    public float fuerzaBala;

    public bool readyToShoot;

    private void Start()
    {
        readyToShoot = true;
    }

    void Update()
    {
        Shooting();
    }

    public void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (readyToShoot))
        {
            FindObjectOfType<SoundManager>().ReproducirSonidoDisparo();

            BulletSpawn();
        }
    }

    public void BulletSpawn()
    {
 
        GameObject bala = Instantiate(balaPrefab, shootPoint.position, shootPoint.rotation).gameObject;

        Rigidbody rb = bala.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * fuerzaBala);

        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {

        readyToShoot = false;

        yield return new WaitForSeconds(1);

        readyToShoot = true;
    }


}
