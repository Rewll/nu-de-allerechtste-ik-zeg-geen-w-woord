using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoekVisueelScript : MonoBehaviour
{
    [SerializeField] private RegelboekLijst regelBoekScript;
    [Header("Boek Visuals")]
    public GameObject PaginaPapierLinks;
    public GameObject PaginaPapierRechts;
    [Space]
    public GameObject streepLinks;
    public GameObject streepRechts;
    [Space]
    public GameObject hoekieLinks;
    public GameObject hoekieRechts;

    private void Start()
    {
        checkPagina();
    }
    public void checkPagina()
    {
        Debug.Log(name + " " + regelBoekScript.lijstVanLijsten.Count);
        if (regelBoekScript.CurrentPage == 0)
        {
            PaginaPapierLinks.SetActive(false);
            streepLinks.SetActive(false);
            hoekieLinks.SetActive(false);
        }
        else if (regelBoekScript.CurrentPage == 2)
        {
            PaginaPapierLinks.SetActive(true);
            streepLinks.SetActive(false);
            hoekieLinks.SetActive(true);
        }
        else if (regelBoekScript.CurrentPage > 2)
        {
            streepLinks.SetActive(true);
        }
        if (regelBoekScript.CurrentPage == regelBoekScript.lijstVanLijsten.Count)
        {
            streepRechts.SetActive(false);
            hoekieRechts.SetActive(false);
        }
        else
        {
            PaginaPapierRechts.SetActive(true);
            PaginaPapierLinks.SetActive(true);
            hoekieRechts.SetActive(true);
            hoekieLinks.SetActive(true);
            streepLinks.SetActive(true);
            streepRechts.SetActive(true);
        }
    }
}