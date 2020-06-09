using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public GameObject Surukle1,Surukle2,Surukle3,Surukle4,Al1,Al2,Al3,Al4;
    Vector2 Surukleilk1, Surukleilk2, Surukleilk3, Surukleilk4;
    public AudioSource ses;
    public AudioClip[] hatasiz;
    public AudioClip hatali;
    public int level_id3;
    bool sorgu1, sorgu2, sorgu3,sorgu4 = false;
    public GameObject SurukleBos1, SurukleBos2, SurukleBos3, SurukleBos4, AlBos1, AlBos2, AlBos3, AlBos4;
    Vector2 Bosilk1, Bosilk2, Bosilk3, Bosilk4;
    void Start()
    {
        level_id3 = PlayerPrefs.GetInt("levelid3");
        Surukleilk1 = Surukle1.transform.position;
        Surukleilk2 = Surukle2.transform.position;
        Surukleilk3 = Surukle3.transform.position;
        Surukleilk4 = Surukle4.transform.position;
        Bosilk1 = SurukleBos1.transform.position;
        Bosilk2 = SurukleBos2.transform.position;
        Bosilk3 = SurukleBos3.transform.position;
        Bosilk4 = SurukleBos4.transform.position;
    }

    public void ESurukle()
    {
        Surukle1.transform.position = Input.mousePosition;
    }
    public void LSurukle()
    {
        Surukle2.transform.position = Input.mousePosition;
    }
    public void MSurukle()
    {
        Surukle3.transform.position = Input.mousePosition;
    }
    public void ASurukle()
    {
        Surukle4.transform.position = Input.mousePosition;
    }
    public void BSurukle1()
    {
        SurukleBos1.transform.position = Input.mousePosition;
    }
    public void BSurukle2()
    {
        SurukleBos2.transform.position = Input.mousePosition;
    }
    public void BSurukle3()
    {
        SurukleBos3.transform.position = Input.mousePosition;
    }
    public void BSurukle4()
    {
        SurukleBos4.transform.position = Input.mousePosition;
    }
    public void Ebirak()
    {
        float mesafe = Vector3.Distance(Surukle1.transform.position, Al1.transform.position);
        if (mesafe < 50)
        {
            Surukle1.transform.position = Al1.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu1 = true;
        }
        else
        {
            Surukle1.transform.position = Surukleilk1;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Lbirak()
    {
        float mesafe = Vector3.Distance(Surukle2.transform.position, Al2.transform.position);
        if (mesafe < 50)
        {
            Surukle2.transform.position = Al2.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu2 = true;
        }
        else
        {
            Surukle2.transform.position = Surukleilk2;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Mbirak()
    {
        float mesafe = Vector3.Distance(Surukle3.transform.position, Al3.transform.position);
        if (mesafe < 50)
        {
            Surukle3.transform.position = Al3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu3 = true;
        }
        else
        {
            Surukle3.transform.position = Surukleilk3;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Abirak()
    {
        float mesafe = Vector3.Distance(Surukle4.transform.position, Surukle4.transform.position);
        if (mesafe < 50)
        {
            Surukle4.transform.position = Al4.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu4 = true;
        }
        else
        {
            Surukle4.transform.position = Surukleilk4;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Bbirak1()
    {
        float mesafe = Vector3.Distance(SurukleBos1.transform.position, AlBos1.transform.position);
        if (mesafe < 50)
        {
            SurukleBos1.transform.position = AlBos1.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            SurukleBos1.transform.position = Bosilk1;
            ses.clip = hatali;
            ses.Play();
        }
    }

    public void Bbirak2()
    {
        float mesafe = Vector3.Distance(SurukleBos2.transform.position, AlBos2.transform.position);
        if (mesafe < 50)
        {
            SurukleBos2.transform.position = AlBos2.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            SurukleBos2.transform.position = Bosilk2;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Bbirak3()
    {
        float mesafe = Vector3.Distance(SurukleBos3.transform.position, AlBos3.transform.position);
        if (mesafe < 50)
        {
            SurukleBos3.transform.position = AlBos3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            SurukleBos3.transform.position = Bosilk3;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void Bbirak4()
    {
        float mesafe = Vector3.Distance(SurukleBos4.transform.position, AlBos4.transform.position);
        if (mesafe < 50)
        {
            SurukleBos4.transform.position = AlBos4.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            SurukleBos4.transform.position = Bosilk4;
            ses.clip = hatali;
            ses.Play();
        }
    }
    void Update()
    {
        if (sorgu1 && sorgu2 && sorgu3 && sorgu4)
        {
           Surukle1.transform.position = Al1.transform.position;
           Surukle2.transform.position = Al2.transform.position;
           Surukle3.transform.position = Al3.transform.position;
           Surukle4.transform.position = Al4.transform.position;
           level_id3++;
            PlayerPrefs.SetInt("levelid3", level_id3);
            Application.LoadLevel(1);
        }
    }
}

