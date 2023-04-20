using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Varda_paradisana : MonoBehaviour {

    private string teksts;
    public GameObject ievadesLauks;
    public GameObject tekstaAttelosana;
    private string[] fragmenti = {"Sveiks ", "Jauku dienu ", "Prieks tevi redzet ", "Uzredzesanos " };
    int ind;

    public void UzglabatTekstu()
    {
        ind = Random.Range(0, fragmenti.Length);
        teksts = ievadesLauks.GetComponent<InputField>().text;
        tekstaAttelosana.GetComponent<Text>().text = fragmenti[ind]+teksts.ToUpper()+"!";
    }


}
