using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject binsImg;
    public GameObject lacitisImg;
    public GameObject omeImg;
    public GameObject masinaImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;


    public void binaAttelosana(bool vertiba)
    {
        binsImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }
    public void lacisaAttelosana(bool vertiba)
    {
        lacitisImg.SetActive(vertiba);
    }
    public void omesAttelosana(bool vertiba)
    {
        omeImg.SetActive(vertiba);
    }
    public void masinaAttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }
    public void paKreisiBeans()
    {
        binsImg.transform.localScale = new Vector2(1, 1);
    }
    public void paLabiBeans()
    {
        binsImg.transform.localScale = new Vector2(-1, 1);
    }
    public void izkritosais(int sk)
    {
        if (sk == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (sk == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        else if (sk == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("Nav piesaistits attels!");
    }
}



