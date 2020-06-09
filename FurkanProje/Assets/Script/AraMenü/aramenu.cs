using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class aramenu : MonoBehaviour
{
    public GameObject aramenuobje,bilgiobje;
    public AudioSource ses2;
    public AudioSource ses3;
    public AudioClip sarki; 
    public AudioClip sarki2;
    public UnityEngine.UI.Button acbuton;
    public UnityEngine.UI.Button kapabuton;

    void Start()
    {
        acbuton.gameObject.SetActive(true);
        kapabuton.gameObject.SetActive(false);
        aramenuobje.SetActive(false);
        bilgiobje.SetActive(false);
        ses2.clip = sarki;
        ses3.clip = sarki2;
    }
    void Update()
    {
 
    }
    public void butonkontrol(string gelen)
    {
        if(gelen == "Durdur")
        {
            aramenuobje.SetActive(true);
            ses2.Pause();
            ses3.Play();
        }
        else if(gelen=="Devam")
        {
            aramenuobje.SetActive(false);
            ses3.Play();
            ses2.UnPause();        
        }
        else if (gelen == "AnaSayfa")
        {
            ses2.Stop();
            ses3.Play();
            SceneManager.LoadScene(0);
        }
        else if(gelen=="Ayarlar")
        {
            ses3.Play();
        }
        else if (gelen == "OyunuKapat")
        {
            ses3.Play();
            Application.Quit();
        }
        else if(gelen=="SesKapa")
        {
            acbuton.gameObject.SetActive(false);
            kapabuton.gameObject.SetActive(true);
            ses2.mute=true;
            ses3.mute=true;
        }
        else if(gelen=="SesAc")
        {
            ses3.Play();
            acbuton.gameObject.SetActive(true);
            kapabuton.gameObject.SetActive(false);
            ses2.mute = false;
            ses3.mute=true;
        }
        else if (gelen == "bilgiac")
        {
            bilgiobje.SetActive(true);
        }
        else if (gelen == "bilgikapa")
        {
            bilgiobje.SetActive(false);
        }
    }
}
