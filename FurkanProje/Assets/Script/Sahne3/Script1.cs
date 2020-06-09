using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Script1 : MonoBehaviour
{

    public GameObject anak, anau, anas, ick, icu, ics,anabos1,anabos2,anabos3,bosic1,bosic2,bosic3;
    Vector2 ilkk, ilku, ilks,ilkbos1,ilkbos2,ilkbos3;
    public AudioSource ses;
    public AudioClip[] hatasiz;
    public AudioClip hatali;
    public AudioClip galibiyet;
    bool ksorgu, usorgu, ssorgu = false;
    public int level_id3;
    void Start()
    {
        level_id3 = PlayerPrefs.GetInt("levelid3");
        ilkk = anak.transform.position;
        ilku = anau.transform.position;
        ilks = anas.transform.position;
        ilkbos1 = anabos1.transform.position;
        ilkbos2 = anabos2.transform.position;
        ilkbos3 = anabos3.transform.position;
    }


public void suruklek()
{
    anak.transform.position = Input.mousePosition;
}
public void surukleu()
{
    anau.transform.position = Input.mousePosition;
}
public void surukles()
{
    anas.transform.position = Input.mousePosition;
}
    public void suruklebos1()
{
    anabos1.transform.position = Input.mousePosition;
}
    public void suruklebos2()
{
    anabos2.transform.position = Input.mousePosition;
}
    public void suruklebos3()
{
    anabos3.transform.position = Input.mousePosition;
}



    public void birakbos1()
    {
        float mesafe = Vector3.Distance(anabos1.transform.position,bosic1.transform.position);
        if (mesafe < 1)
        {
            anabos1.transform.position = bosic1.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            anabos1.transform.position = ilkbos1;
            ses.clip = hatali;
            ses.Play();
        }

    }


    public void birakbos2()
    {
        float mesafe = Vector3.Distance(anabos2.transform.position, bosic2.transform.position);
        if (mesafe < 1)
        {
            anabos2.transform.position = bosic2.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            anabos2.transform.position = ilkbos2;
            ses.clip = hatali;
            ses.Play();
        }

    }


    public void birakbos3()
    {
        float mesafe = Vector3.Distance(anabos3.transform.position, bosic3.transform.position);
        if (mesafe < 1)
        {
            anabos3.transform.position = bosic3.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
        }
        else
        {
            anabos3.transform.position = ilkbos3;
            ses.clip = hatali;
            ses.Play();
        }

    }

    public void birakk()
{
    float mesafe = Vector3.Distance(anak.transform.position, ick.transform.position);
        if(mesafe<50)
        {
            anak.transform.position = ick.transform.position;
           ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            ksorgu = true;
        }
        else
        {
            anak.transform.position = ilkk;
            ses.clip = hatali;
            ses.Play();
        }
}
    public void biraku()
    {
        float mesafe = Vector3.Distance(anau.transform.position, icu.transform.position);
        if (mesafe < 50)
        {
            anau.transform.position = icu.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            usorgu = true;
        }
        else
        {
            anau.transform.position = ilku;
            ses.clip = hatali;
            ses.Play();
        }
    }
    public void biraks()
    {
        float mesafe = Vector3.Distance(anas.transform.position, ics.transform.position);
        if (mesafe < 50)
        {
            anas.transform.position = ics.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            ssorgu = true;
        }
        else
        {
            anas.transform.position = ilks;
            ses.clip = hatali;
            ses.Play();
        }
    }

    void Update()
    {
        if (ksorgu && usorgu && ssorgu)
        {
            anas.transform.position = ics.transform.position;
            anau.transform.position = icu.transform.position;
            anak.transform.position = ick.transform.position;
            level_id3++;
            PlayerPrefs.SetInt("levelid3", level_id3);
            Application.LoadLevel(1);
        }

    }
}

