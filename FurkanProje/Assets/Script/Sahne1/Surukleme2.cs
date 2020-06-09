using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Surukleme2 : MonoBehaviour
{
    [SerializeField]
    Text bilgiyazisi;
    public GameObject kare, yildiz, ucgen, yuvarlak,besgen,altigen,dikdortgen,yamuk,kareic, yildizic, ucgenic, yuvarlakic,besgenic,altigenic,dikdortgenic,yamukic;
    Vector2 kareilk, yildizilk, ucgenilk, yuvarlakilk,besgenilk, altigenilk, dikdortgenilk, yamukilk;
    public AudioSource ses;
    public AudioClip[] hatasiz;
    public AudioClip hatali;
    public int level_id2;
    bool karesorgu, yildizsorgu, ucgensorgu, yuvarlaksorgu,besgensorgu,altigensorgu,dikdortgensorgu,yamuksorgu = false;
    void Start()
    {
        level_id2 = PlayerPrefs.GetInt("levelid2");
        kareilk = kare.transform.position;
        yildizilk = yildiz.transform.position;
        ucgenilk = ucgen.transform.position;
        yuvarlakilk = yuvarlak.transform.position;
        besgenilk = besgen.transform.position;
        altigenilk = altigen.transform.position;
        dikdortgenilk = dikdortgen.transform.position;
        yamukilk = yamuk.transform.position;
    }

public void karesurukle()
{
    kare.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Kare";
}
public void yildizsurukle()
{
    yildiz.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Yıldız";
}
public void ucgensurukle()
{
    ucgen.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Üçgen";
}
public void yuvarlaksurukle()
{
    yuvarlak.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Yuvarlak";
}
public void besgensurukle()
{
    besgen.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Beşgen";
}
public void altigensurukle()
{
    altigen.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Altıgen";
}
public void dikdortgensurukle()
{
    dikdortgen.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Dikdörtgen";
}
public void yamuksurukle()
{
    yamuk.transform.position = Input.mousePosition;
    bilgiyazisi.text = "Yamuk";
}

    public void karebirak()
{
    float mesafe = Vector3.Distance(kare.transform.position, kareic.transform.position);
        if(mesafe<50)
        {
            kare.transform.position = kareic.transform.position;
           ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            karesorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            kare.transform.position = kareilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
}
    public void yildizbirak()
    {
        float mesafe = Vector3.Distance(yildiz.transform.position, yildizic.transform.position);
        if (mesafe < 50)
        {
            yildiz.transform.position = yildizic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            yildizsorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            yildiz.transform.position = yildizilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void ucgenbirak()
    {
        float mesafe = Vector3.Distance(ucgen.transform.position, ucgenic.transform.position);
        if (mesafe < 50)
        {
            ucgen.transform.position = ucgenic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            ucgensorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            ucgen.transform.position = ucgenilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void yuvarlakbirak()
    {
        float mesafe = Vector3.Distance(yuvarlak.transform.position, yuvarlakic.transform.position);
        if (mesafe < 50)
        {
            yuvarlak.transform.position = yuvarlakic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            yuvarlaksorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            yuvarlak.transform.position = yuvarlakilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void besgenbirak()
    {
        float mesafe = Vector3.Distance(besgen.transform.position, besgenic.transform.position);
        if (mesafe < 50)
        {
            besgen.transform.position = besgenic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            besgensorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            besgen.transform.position = besgenilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void altigenbirak()
    {
        float mesafe = Vector3.Distance(altigen.transform.position, altigenic.transform.position);
        if (mesafe < 50)
        {
            altigen.transform.position = altigenic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            altigensorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            altigen.transform.position = altigenilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void dikdortgenbirak()
    {
        float mesafe = Vector3.Distance(dikdortgen.transform.position, dikdortgenic.transform.position);
        if (mesafe < 50)
        {
            dikdortgen.transform.position = dikdortgenic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            dikdortgensorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            dikdortgen.transform.position = dikdortgenilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
    public void yamukbirak()
    {
        float mesafe = Vector3.Distance(yamuk.transform.position, yamukic.transform.position);
        if (mesafe < 50)
        {
            yamuk.transform.position = yamukic.transform.position;
            ses.clip = hatasiz[Random.Range(0, hatasiz.Length)];
            ses.Play();
            yamuksorgu = true;
            bilgiyazisi.text = "";
        }
        else
        {
            yamuk.transform.position = yamukilk;
            ses.clip = hatali;
            ses.Play();
            bilgiyazisi.text = "";
        }
    }
  void Update()     
    {
        if (karesorgu && yildizsorgu && ucgensorgu && yuvarlaksorgu && besgensorgu && altigensorgu && dikdortgensorgu && yamuksorgu)
        {
            yuvarlak.transform.position = yuvarlakic.transform.position;
            ucgen.transform.position = ucgenic.transform.position;
            yildiz.transform.position = yildizic.transform.position;
            kare.transform.position = kareic.transform.position;
            level_id2++;
            PlayerPrefs.SetInt("levelid2", level_id2);
            Application.LoadLevel(1);
        }
    }
    }
