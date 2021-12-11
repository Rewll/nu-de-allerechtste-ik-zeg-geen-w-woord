using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    public GameManager gameManager;
    public int textIndex;
    Text naamTekst;

    private void Start()
    {
        naamTekst = GetComponent<Text>();
        naamTekst.text = gameManager.gekozenNamenLijst[textIndex];
    }
}
