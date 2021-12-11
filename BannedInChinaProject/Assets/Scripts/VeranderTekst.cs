using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VeranderTekst : MonoBehaviour
{
    [SerializeField]
    private Text tekst;
    public string ervoor;
    public string erachter;

    public void VeranderNieuweTekst(string nieuweTekst)
    {
        tekst.text = ervoor + nieuweTekst + erachter;
    }
}