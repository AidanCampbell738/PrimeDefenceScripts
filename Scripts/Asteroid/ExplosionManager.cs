using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager: MonoBehaviour
{
    public AudioSource explosionAudio;

    void Start()
    {
        explosionAudio.Play();
        Destroy(gameObject, 0.5f);
    }
}
