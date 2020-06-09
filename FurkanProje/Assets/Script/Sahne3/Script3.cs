using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public GameObject Surukle1, Surukle2, Surukle3, Surukle4,Surukle5 ,Al1, Al2, Al3, Al4,Al5;
    Vector2 Surukleilk1, Surukleilk2, Surukleilk3, Surukleilk4,Surukleilk5;
    public AudioSource ses;
    public AudioClip[] hatasiz;
    public AudioClip hatali;
    public int level_id3;
    bool sorgu1, sorgu2, sorgu3, sorgu4,sorgu5 = false;
    public GameObject SurukleBos1, SurukleBos2, SurukleBos3, SurukleBos4,SurukleBos5, AlBos1, AlBos2, AlBos3, AlBos4,Albos5;
    Vector2 Bosilk1, Bosilk2, Bosilk3, Bosilk4,Bosilk5;
    void Start()
    {
        level_id3 = PlayerPrefs.GetInt("levelid3");
        Surukleilk1 = Surukle1.transform.position;
        Surukleilk2 = Surukle2.transform.position;
        Surukleilk3 = Surukle3.transform.position;
        Surukleilk4 = Surukle4.transform.position;
        Surukleilk5 = Surukle5.transform.position;
        Bosilk1 = SurukleBos1.transform.position;
        Bosilk2 = SurukleBos2.transform.position;
        Bosilk3 = SurukleBos3.transform.position;
        Bosilk4 = SurukleBos4.transform.position;
        Bosilk5 = SurukleBos5.transform.position;
    }

    public void SurukleA1()
    {
        Surukle1.transform.position = Input.mousePosition;
    }
    public void SurukleR()
    {
        Surukle2.transform.position = Input.mousePosition;
    }
    public void SurukleA2()
    {
        Surukle3.transform.position = Input.mousePosition;
    }
    public void SurukleB()
    {
        Surukle4.transform.position = Input.mousePosition;
    }
    public void SurukleA3()
    {
        Surukle5.transform.position = Input.mousePosition;
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
    public void BSurukle5()
    {
        SurukleBos5.transform.position = Input.mousePosition;
    }



    public void BirakA1()
    {
        float mesafe = Vector3.Distance(Surukle1.transform.position, Al1.transform.position);
        float mesafe2 = Vector3.Distance(Surukle1.transform.position, Al3.transform.position);
        float mesafe3 = Vector3.Distance(Surukle1.transform.position, Al5.transform.position);
        if (mesafe < 50)
        {
            Surukle1.transform.position = Al1.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu1 = true;
        }
        else if(mesafe2<50)
        {
            Surukle1.transform.position = Al3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu3 = true;
        }
        else if (mesafe3 < 50)
        {
            Surukle1.transform.position = Al5.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu5 = true;
        }
        else
        {
            Surukle1.transform.position = Surukleilk1;
            ses.clip = hatali;
            ses.Play();
        }
    }


       public void BirakR()
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
    public void BirakA2()
    {
        float mesafe = Vector3.Distance(Surukle3.transform.position, Al3.transform.position);
        float mesafe2 = Vector3.Distance(Surukle3.transform.position, Al1.transform.position);
        float mesafe3 = Vector3.Distance(Surukle3.transform.position, Al5.transform.position);
        if (mesafe < 50)
        {
            Surukle3.transform.position = Al3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu3 = true;
        }
        else if (mesafe2 < 50)
        {
            Surukle3.transform.position=Al1.transform.position;
              ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu1 = true;
        }
        else if (mesafe3 < 50)
        {
            Surukle3.transform.position = Al5.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu5 = true;
        }
        else
        {
            Surukle3.transform.position = Surukleilk3;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void BirakB()
    {
        float mesafe = Vector3.Distance(Surukle4.transform.position, Al4.transform.position);
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
    public void BirakA3()
    {
        float mesafe = Vector3.Distance(Surukle5.transform.position, Al5.transform.position);
        float mesafe2 = Vector3.Distance(Surukle5.transform.position, Al3.transform.position);
        float mesafe3 = Vector3.Distance(Surukle5.transform.position, Al1.transform.position);
        if (mesafe < 50)
        {
            Surukle5.transform.position = Al5.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu5 = true;
        }
        else if(mesafe2 < 50)
        {
            Surukle5.transform.position = Al3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu3 = true;
        }
        else if (mesafe3 < 50)
        {
            Surukle5.transform.position = Al1.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            sorgu1 = true;
        }
        else
        {
            Surukle5.transform.position = Surukleilk5;
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

    public void Bbirak5()
    {
        float mesafe = Vector3.Distance(SurukleBos5.transform.position, Albos5.transform.position);
        if (mesafe < 50)
        {
            SurukleBos5.transform.position = Albos5.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            SurukleBos5.transform.position = Bosilk5;
            ses.clip = hatali;
            ses.Play();
        }
    }



    void Update()
    {
        if (sorgu1 && sorgu2 && sorgu3 && sorgu4 && sorgu5)
        {
            Surukle1.transform.position = Al1.transform.position;
            Surukle2.transform.position = Al2.transform.position;
            Surukle3.transform.position = Al3.transform.position;
            Surukle4.transform.position = Al4.transform.position;
            Surukle5.transform.position = Al5.transform.position;
           level_id3++;
            PlayerPrefs.SetInt("levelid3", level_id3);
            Application.LoadLevel(1);

        }
    }
}
