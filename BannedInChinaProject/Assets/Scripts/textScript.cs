using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textScript : MonoBehaviour
{
    public GameManager gameManager;
    public int textIndex;
    TMP_Text text;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        text.text = gameManager.gekozenNamenLijst[textIndex];
    }
}
