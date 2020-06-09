using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class anamenu : MonoBehaviour
{
    public GameObject aramenuobje,aramenuobje2,aramenuobje3;
    void Start()
    {
        aramenuobje.SetActive(false);
        aramenuobje2.SetActive(false);
        aramenuobje3.SetActive(false);
    }
     public void butonkontrol(string gelen)
    {
        if (gelen == "basla")
         {
             SceneManager.LoadScene(1);
         }
         else if (gelen == "oyun1")
         {
             aramenuobje.SetActive(true);
         }
         else if (gelen == "oyun2")
         {
             aramenuobje2.SetActive(true);
         }
         else if (gelen == "oyun3")
         {
             aramenuobje3.SetActive(true);
         }
         else if (gelen == "carpi")
         {
             aramenuobje.SetActive(false);
             aramenuobje2.SetActive(false);
             aramenuobje3.SetActive(false);
         }
         else if (gelen == "geri")
         {
             Application.LoadLevel(0);
         }
         else if (gelen == "ayarlar")
         {
             
         }
         else if (gelen == "cikis")
         {
             Application.Quit();
         }
    }
}
