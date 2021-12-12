using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PersonGenration : MonoBehaviour
{
    public GameManager gm;
    public string PersonName;
    public string Job;
    public int illegalChance;
    public GameManager.legalState personStateOfLegal;
    //[Space]
    //[SerializeField]
    //private UnityEvent<string> geefNaamDoor;
    //[SerializeField]
    //private UnityEvent<string> geefBaanDoor;
    private bool firstTime;

    void Start()
    {
        //first person generated
        firstTime = true;
        generatePerson();
    }

    public void generatePerson()
    {
        Job = gm.alleBeroepen[Random.Range(0, gm.alleBeroepen.Count)];

        if (Random.Range(0, illegalChance) == 0)
        {
            int illegalThing;
            switch (illegalThing = Random.Range(1, 4))
            {
                case 1:
                    personStateOfLegal = GameManager.legalState.illegalName;
                    chooseIllegalName();
                    break;
                case 2:
                    personStateOfLegal = GameManager.legalState.illegalSuitCase;
                    chooseLegalName();
                    break;
                case 3:
                    personStateOfLegal = GameManager.legalState.illegalJob;
                    chooseLegalName();
                    break;
            }
        }
        else 
        {
            personStateOfLegal = GameManager.legalState.legal;
            PersonName = gm.gekozenNamenLijst[Random.Range(0, gm.gekozenNamenLijst.Count)];
            chooseLegalName();
        }
        //geefNaamDoor.Invoke(PersonName);
        //geefBaanDoor.Invoke(Job);
    }

    void chooseIllegalName()
    {
        do
        {
            PersonName = gm.alleVoorNamen[Random.Range(0, gm.alleVoorNamen.Count)] + " " +
                         gm.alleAchterNamen[Random.Range(0, gm.alleAchterNamen.Count)];
        } while (gm.gekozenNamenLijst.Contains(PersonName));
    }

    void chooseLegalName()
    {
        PersonName = gm.gekozenNamenLijst[Random.Range(0, gm.gekozenNamenLijst.Count)];
        if (!firstTime)
        {
            gm.gekozenNamenLijst.Remove(PersonName);
        }
        else
        {
            firstTime = false;
        }
    }
}