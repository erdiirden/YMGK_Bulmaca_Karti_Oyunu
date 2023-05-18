using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meow : MonoBehaviour
{
    AudioSource meowww;
    void Start()
    {
        meowww = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }
    public void miyavlat()
    {
        meowww.Play();
    }
}
