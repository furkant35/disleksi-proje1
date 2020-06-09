using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkilitle3 : MonoBehaviour
{
    public int level_idkontrol3, coz3;
    public Button[] leveller3;

    public void bolum_ac(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);
    }
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        for (int i = 1; i <= leveller3.Length - 1; i++)
        {
            leveller3[i].interactable = false;
        }
    }
    void Update()
    {

        level_idkontrol3 = PlayerPrefs.GetInt("levelid3");
        coz3 = PlayerPrefs.GetInt("coz3");
        if (level_idkontrol3 > 0)
        {
            leveller3[level_idkontrol3].interactable = true;
        }
        for (int i = 0; i <= level_idkontrol3; i++)
        {
            leveller3[i].interactable = true;
        }
    }
    public void hatacoz3(int deger3)
    {
        coz3 = deger3;
        if (coz3 < level_idkontrol3)
        {
            PlayerPrefs.SetInt("levelid3", level_idkontrol3 - 1);
        }
    }
}

