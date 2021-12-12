using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPageExtras : MonoBehaviour
{
    [SerializeField] private NamenLijstGeneratie NamenLijstGeneratie;

    public void CheckIfLastPage()
    {
        if (NamenLijstGeneratie.CurrentPage == NamenLijstGeneratie.lijstVanLijsten.Count - 1)
        {
            gameObject.SetActive(false);
        }
    }
}
