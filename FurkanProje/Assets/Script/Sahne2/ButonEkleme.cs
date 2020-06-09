using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonEkleme : MonoBehaviour
{
    [SerializeField]
    private Transform anaobje;
    [SerializeField]
    private GameObject btn;
    void Awake()
    {
        for(int i=0;i<8;i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(anaobje, false);
        }
    }
}
