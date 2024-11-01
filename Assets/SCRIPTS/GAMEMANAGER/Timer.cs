using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    private float timerTime;

    // Update is called once per frame
    void Update()
    {
        ContadorTiempo();
    }

    private void ContadorTiempo()
    {
        timerTime += Time.deltaTime;
        int tiempo = (int)timerTime;
        timer.text = "Has viajado por " + tiempo.ToString() + " segundos";
    }
}
