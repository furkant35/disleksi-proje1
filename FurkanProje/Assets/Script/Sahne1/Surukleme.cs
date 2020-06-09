using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Surukleme : MonoBehaviour
{
    [SerializeField]
    Text bilgiyazisi;
    public GameObject kare, yildiz, ucgen, yuvarlak, kareic, yildizic, ucgenic, yuvarlakic;
    Vector2 kareilk, yildizilk, ucgenilk, yuvarlakilk;
    public AudioSource ses;
    public AudioClip[] hatasiz;
    public AudioClip hatali;
    public int level_id2;
    bool karesorgu, yildizsorgu, ucgensorgu, yuvarlaksorgu = false;
    void Start()
    {
        level_id2 = PlayerPrefs.GetInt("levelid2");
        kareilk = kare.transform.position;
        yildizilk = yildiz.transform.position;
        ucgenilk = ucgen.transform.position;
        yuvarlakilk = yuvarlak.transform.position;
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
  void Update()     
    {
        if(karesorgu && yildizsorgu && ucgensorgu && yuvarlaksorgu)
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
