using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonGenration : MonoBehaviour
{
    public GameManager gm;
    public string PersonName;
    public string Job;
    public enum legalState { legal, illegalName, illegalSuitCase, illegalJob}
    public legalState personStateOfLegal;
    public int illegalChance;

    void Start()
    {
        generatePerson();
    }

    public void generatePerson()
    {
        Job = gm.alleBeroepen[Random.Range(0, gm.alleBeroepen.Count)];

        if (Random.Range(0, illegalChance) == 1)
        {
            int illegalThing;
            switch (illegalThing = Random.Range(1, 3))
            {
                case 1:
                    personStateOfLegal = legalState.illegalName;
                    chooseIllegalName();
                    break;
                case 2:
                    personStateOfLegal = legalState.illegalSuitCase;
                    chooseLegalName();
                    break;
                case 3:
                    personStateOfLegal = legalState.illegalJob;
                    chooseLegalName();
                    break;
            }
        }
        else 
        {
            personStateOfLegal = legalState.legal;
            PersonName = gm.gekozenNamenLijst[Random.Range(0, gm.gekozenNamenLijst.Count)];
            chooseLegalName();
        }
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
        gm.gekozenNamenLijst.Remove(PersonName);
    }
}