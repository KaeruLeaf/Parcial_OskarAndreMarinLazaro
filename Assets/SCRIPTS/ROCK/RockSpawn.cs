using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    public GameObject rockPrefab;

    public float speed;

    private bool readyToSpawn;

    private void Start()
    {
        StartCoroutine(SpawnDelay());
    }
    void Update()
    {
        if (readyToSpawn) Spawn();
    }

    private void Spawn()
    {
        float posicionX = Random.Range(-7f, 7f);

        Vector3 posicionSpawn = new Vector3 (posicionX,6f,0f);

        GameObject rock = Instantiate(rockPrefab, posicionSpawn, Quaternion.identity);

        Rigidbody rb = rock.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.down * speed);

        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        readyToSpawn = false;

        float tiempoSpawn = Random.Range(1f, 3f);

        yield return new WaitForSeconds(tiempoSpawn);

        readyToSpawn = true;
    }

}
