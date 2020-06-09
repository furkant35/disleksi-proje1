using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelkilitle : MonoBehaviour
{
    public int level_idkontrol,coz;
    public Button[] leveller;
    public void bolum_ac(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);
    }
    void Start()
    {
        // PlayerPrefs.DeleteAll();
        for (int i = 1; i <= leveller.Length - 1; i++)
        {
            leveller[i].interactable = false;
        }
    }
    void Update()
    {

        level_idkontrol = PlayerPrefs.GetInt("levelid");
         coz = PlayerPrefs.GetInt("coz");
        if (level_idkontrol > 0)
        {
            leveller[level_idkontrol].interactable = true;
        }
        for (int i = 0; i <= level_idkontrol; i++)
        {
            leveller[i].interactable = true;
        }
    }
      public void hatacoz(int deger)
      {
          coz = deger;
          if(coz<level_idkontrol)
          {
              PlayerPrefs.SetInt("levelid", level_idkontrol - 1);
          }
      }
}
