using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiklamaSes : MonoBehaviour
{
    AudioSource tikSes;
    public Button sesButonu, cikisButonu, doyurButonu, kucukCikisButonu;
    public Sprite sesFoto, cikisFoto, doyurFoto, sesFotoDefault, cikisFotoDefault, doyurFotoDefault, sesAcikFoto, sesKapaliFoto;
    bool sesKontrol = true;
    public Sprite kucukCikisFoto, kucukCikisFotoDefault;
    public GameObject kaybetti;
    void Start()
    {
        tikSes = GetComponent<AudioSource>();
        tikSes.Pause();
        sesButonu = GetComponent<Button>();
        cikisButonu = GetComponent<Button>();
        doyurButonu = GetComponent<Button>();
        kucukCikisButonu = GetComponent<Button>();
    }
    void Update()
    {
        
    }
    public void cikisButon()
    {
        tikSes.Play();
        Application.Quit();
    }
    public void cikisTýklanýyor()
    {
        cikisButonu.image.sprite = cikisFoto;
    }
    public void cikisTýklandý()
    {
        cikisButonu.image.sprite = cikisFotoDefault;
    }
    public void sesButon()
    {
        tikSes.Play();
        if (sesKontrol == true)
        {
            sesButonu.image.sprite = sesFoto;
            sesKontrol = false;
            AudioListener.volume = 0;
        }
        else
        {
            sesButonu.image.sprite = sesFotoDefault;
            sesKontrol = true;
            AudioListener.volume = 1;
        }
    }
    public void sesTiklaniyor()
    {
        if (sesKontrol == true)
        {
            sesButonu.image.sprite = sesAcikFoto;
        }
        else
        {
            sesButonu.image.sprite = sesKapaliFoto;
        }
    }
    public void doyurButon()
    {
        tikSes.Play();
    }
    public void doyurTiklaniyor()
    {
        doyurButonu.image.sprite = doyurFoto;
    }
    public void doyurTiklandi()
    {
        doyurButonu.image.sprite = doyurFotoDefault;
    }
    public void kucukCikis()
    {
        tikSes.Play();
        kaybetti.SetActive(false);
    }
    public void kucukCikisTiklaniyor()
    {
        kucukCikisButonu.image.sprite = kucukCikisFoto;
    }
    public void kucukCikisTiklandi()
    {
        kucukCikisButonu.image.sprite = kucukCikisFotoDefault;
    }
}
