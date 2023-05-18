using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basarili : MonoBehaviour
{
    AudioSource basariliSes;
    public bool calsinMi = false;

    void Start()
    {
        basariliSes = GetComponent<AudioSource>();
        basariliSes.Play();
    }
    void Update()
    {
    }
}
