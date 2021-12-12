using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPageExtras : MonoBehaviour
{
    [SerializeField] private NamenLijstGeneratie NamenLijstGeneratie;
    public void CheckIfFirstPage()
    {
        if (NamenLijstGeneratie.CurrentPage == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
