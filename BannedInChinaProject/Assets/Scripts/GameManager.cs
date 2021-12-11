using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PersonGenration pg;

    public int mensenAantal;
    public GameObject currentPerson;
    public int socialCreditScoreTest;
    private string playerInput;
    [Space]
    public List<string> gekozenNamenLijst = new List<string>();
    [Space]
    public List<string> alleVoorNamen = new List<string>();
    public List<string> alleAchterNamen = new List<string>();
    public List<string> alleBeroepen = new List<string>();
    public List<GameObject> AlleIllegalIitems = new List<GameObject>();
    public List<GameObject> AlleLegalItems = new List<GameObject>();
    public List<GameObject> AllFaces = new List<GameObject>();


    void Start()
    {
        genereerLijst();
    }

    //wist je da thg
    void genereerLijst()
    {
        while (gekozenNamenLijst.Count != mensenAantal)
        {
            string name = alleVoorNamen[Random.Range(0, alleVoorNamen.Count)] + " " +
              alleAchterNamen[Random.Range(0, alleAchterNamen.Count)];
            if (!gekozenNamenLijst.Contains(name))
            {
                gekozenNamenLijst.Add(name);
            } 
        }
    }

    public void legal()
    {
        if (pg.personStateOfLegal.ToString() == "legal")
        {
            socialCreditScoreTest += 2;
        }
        else //Slecht geantwoord
        {
            socialCreditScoreTest -= 10;
        }
        nextPerson();
    }

    public void illegal()
    {
        if (pg.personStateOfLegal.ToString() != "legal") //Goed geantwoord
        {
            socialCreditScoreTest += 2;
        }
        else //Slecht geantwoord
        {
            socialCreditScoreTest -= 10;

        }
        nextPerson();
    }

    void nextPerson()
    {
        pg.generatePerson();
    }

}