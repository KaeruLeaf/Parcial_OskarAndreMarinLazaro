using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RocksCounter : MonoBehaviour
{
    public float rocksDestroyed;

    public TextMeshProUGUI contadorRocks;

    void Start()
    {
        rocksDestroyed = 0;
        ActualizarConteo();
    }

    public void IncrementarRock()
    {
        rocksDestroyed++;

        ActualizarConteo();
    }

    public void ActualizarConteo()
    {
        contadorRocks.text = "Rocas destruidas: " + rocksDestroyed.ToString();
    }
 
}
