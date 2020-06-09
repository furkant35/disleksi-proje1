using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OyunKontrolü3 : MonoBehaviour
{
    [SerializeField]
    private Sprite apGoruntu;
    public int level_id;
    public Sprite[] parca;
    public List<Sprite> oyunparca = new List<Sprite>();
    public List<Button> butonlar = new List<Button>();

    private bool tahmin1, tahmin2;
    private int sayitahmin;
    private int dogrutahminsayi;
    private int oyuntahmin;
    private int tahminindex1, tahminindex2;
    private string secilen1, secilen2;

    public AudioSource seskaynak;
    public AudioClip ses;

    void Awake()
    {
        parca = Resources.LoadAll<Sprite>("Sprites/aktarhayvan");
    }
    void Start()
    {
        level_id = PlayerPrefs.GetInt("levelid");
        seskaynak.clip = ses;
        GetButtons();
        dinleyiciekle();
        oyunparcaekle();
        randomatama(oyunparca);
        oyuntahmin = oyunparca.Count / 2;
    }
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("OyunButon");
        for (int i = 0; i < objects.Length; i++)
        {
            butonlar.Add(objects[i].GetComponent<Button>());
            butonlar[i].image.sprite = apGoruntu;
        }
    }
    void oyunparcaekle()
    {
        int looper = butonlar.Count;
        int index = 0;
        for (int i = 0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }
            oyunparca.Add(parca[index]);
            index++;
        }
    }
    void dinleyiciekle()
    {
        foreach (Button btn in butonlar)
        {
            btn.onClick.AddListener(() => secim());
        }
    }
    public void secim()
    {
        seskaynak.Play();
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (!tahmin1)
        {
            tahmin1 = true;
            tahminindex1 = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secilen1 = oyunparca[tahminindex1].name;
            butonlar[tahminindex1].image.sprite = oyunparca[tahminindex1];
        }
        else if (!tahmin2)
        {
            tahmin2 = true;
            tahminindex2 = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secilen2 = oyunparca[tahminindex2].name;
            butonlar[tahminindex2].image.sprite = oyunparca[tahminindex2];
            sayitahmin++;
            StartCoroutine(eslesmekontrol());
        }
    }
    IEnumerator eslesmekontrol()
    {
        yield return new WaitForSeconds(1f);
        if (secilen1 == secilen2)
        {
            yield return new WaitForSeconds(.1f);
            butonlar[tahminindex1].interactable = false;
            butonlar[tahminindex2].interactable = false;
            butonlar[tahminindex1].image.color = new Color(0, 0, 0, 0);
            butonlar[tahminindex2].image.color = new Color(0, 0, 0, 0);
            dogrueslesme();
        }
        else
        {
            yield return new WaitForSeconds(.5f);
            butonlar[tahminindex1].image.sprite = apGoruntu;
            butonlar[tahminindex2].image.sprite = apGoruntu;

        }
        yield return new WaitForSeconds(.5f);
        tahmin1 = tahmin2 = false;
    }
    void dogrueslesme()
    {
        dogrutahminsayi++;
        if (dogrutahminsayi == oyuntahmin)
        {
           level_id++;
            PlayerPrefs.SetInt("levelid", level_id);
            Application.LoadLevel(1);
        }
    }
    void randomatama(List<Sprite> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Sprite gecici = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = gecici;
        }
    }
}
