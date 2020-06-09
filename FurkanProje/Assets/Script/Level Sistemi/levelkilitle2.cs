using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelkilitle2 : MonoBehaviour
{
    public int level_idkontrol2, coz2;
    public Button[] leveller2;
    public void bolum_ac(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);
    }
    void Start()
    {
       //PlayerPrefs.DeleteAll();
        for (int i = 1; i <= leveller2.Length - 1; i++)
        {
            leveller2[i].interactable = false;
        }
    }
    void Update()
    {

        level_idkontrol2 = PlayerPrefs.GetInt("levelid2");
        coz2 = PlayerPrefs.GetInt("coz2");
        if (level_idkontrol2 > 0)
        {
            leveller2[level_idkontrol2].interactable = true;
        }
        for (int i = 0; i <= level_idkontrol2; i++)
        {
            leveller2[i].interactable = true;
        }
    }
    public void hatacoz2(int deger2)
    {
        coz2 = deger2;
        if (coz2 < level_idkontrol2)
        {
            PlayerPrefs.SetInt("levelid2", level_idkontrol2 - 1);
        }
    }
}
