using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioShot;
    public AudioSource audioRespawn;
    public AudioSource audioRockDestroy;

    private void Start()
    {
        audioShot.Stop();
        audioRespawn.Stop();
        audioRockDestroy.Stop();
    }
    public void ReproducirSonidoReinicio()
    {
        audioRespawn.Play();
    }

    public void ReproducirSonidoDisparo()
    {
        audioShot.Play();
    }

    public void ReproducirSonidoColision()
    {
        audioRockDestroy.Play();
    }
}
