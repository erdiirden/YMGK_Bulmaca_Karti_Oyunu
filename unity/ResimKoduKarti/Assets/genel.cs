using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class genel : MonoBehaviour
{
    int balik, yumurta, kasar, et;
    public InputField balikVerisi;
    public InputField yumurtaVerisi;
    public InputField kasarVerisi;
    public InputField etVerisi;
    public GameObject kazandi,kaybetti;
    AudioSource anaMuzik;
    void Start()
    {
        anaMuzik = GetComponent<AudioSource>();
        anaMuzik.Play();
    }
    void Update()
    {
        
    }
    public void kediDoyur()
    {
        try
        {
            balik = int.Parse(balikVerisi.text);
            yumurta = int.Parse(yumurtaVerisi.text);
            kasar = int.Parse(kasarVerisi.text);
            et = int.Parse(etVerisi.text);
        }
        catch
        {
            balik = 99;
            yumurta = 99;
            kasar = 99;
            et = 99;
        }
        if (balik==1 & yumurta==4 & kasar==3 & et==2)
        {
            Debug.Log("Cevabýn Doðru kedi doydu");
            anaMuzik.Pause();
            kazandi.SetActive(true);
        }
        else
        {
            Debug.Log("Cevap yanlýþ yeniden dene");
            kaybetti.SetActive(true);
        }
        
    }
}
