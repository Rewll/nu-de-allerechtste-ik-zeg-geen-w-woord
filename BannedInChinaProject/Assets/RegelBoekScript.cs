using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegelBoekScript : MonoBehaviour
{
    [SerializeField]
    List<GameObject> PagePrefabs = new List<GameObject>();
    [Space]
    public int huidigePagina;
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
    public void Volgende()
    {
        huidigePagina++;
        checkPagina();
    }
    public void Vorige()
    {
        huidigePagina--;
        checkPagina();
    }

    public void checkPagina()
    {
        if (huidigePagina == 0)
        {
            PagePrefabs[huidigePagina].SetActive(true);
            for (int i = 1; i < PagePrefabs.Count; i++)
            {
                PagePrefabs[i].SetActive(false);
            }

            PaginaPapierLinks.SetActive(false);
            hoekieLinks.SetActive(false);
            streepLinks.SetActive(false);

        }
        //else if (huidigePagina == PagePrefabs.Count)
        //{
        //    PagePrefabs[huidigePagina].SetActive(true);
        //    for (int i = 1; i < PagePrefabs.Count; i++)
        //    {
        //        if (i != huidigePagina)
        //        {
        //            PagePrefabs[i].SetActive(false);
        //            PagePrefabs[i + 1].SetActive(false);
        //        }
        //    }
        //}
        else
        {
            PagePrefabs[huidigePagina].SetActive(true);
            PagePrefabs[huidigePagina + 1].SetActive(true);
            for (int i = 1; i < PagePrefabs.Count; i++)
            {
                if (i != huidigePagina && i != huidigePagina + 1)
                {
                    PagePrefabs[i].SetActive(false);
                }
            }

            PaginaPapierLinks.SetActive(true);
            hoekieLinks.SetActive(true);
            streepLinks.SetActive(true);
            streepRechts.SetActive(true);
            hoekieRechts.SetActive(true);
            PaginaPapierRechts.SetActive(true);
        }
    }


}
