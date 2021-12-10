using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briefcase : MonoBehaviour
{
    private PersonGenration PersonScript;
    private GameManager GameManager;
    [SerializeField] private GameObject gameManager;
    [SerializeField] private GameObject people;
    [SerializeField] private int AmountOfItems; 

    private void Awake()
    {
        PersonScript = people.GetComponent<PersonGenration>();
        GameManager = gameManager.GetComponent<GameManager>();
    }
    public void GenerateNewBriefcase()
    {
        if (PersonScript.personStateOfLegal.ToString() == "illegalSuitCase")
        {
            Instantiate(GameManager.AlleIllegalIitems[Random.Range(0, GameManager.AlleIllegalIitems.Count)]);
            for (int i = 0; i < AmountOfItems -1; i++)
            {
                Instantiate(GameManager.AlleLegalItems[Random.Range(0, GameManager.AlleLegalItems.Count)]);
            }
        }
        else
        {

        }


    }
}
