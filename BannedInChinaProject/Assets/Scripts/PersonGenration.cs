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

        PersonName = gm.gekozenNamenLijst[Random.Range(0, gm.gekozenNamenLijst.Count)];
        Job = gm.alleBeroepen[Random.Range(0, gm.alleBeroepen.Count)];

        if (Random.Range(0, illegalChance) == 1)
        {
            int illegalThing;
            switch (illegalThing = Random.Range(1, 3))
            {
                case 1:
                    personStateOfLegal = legalState.illegalName;
                    break;
                case 2:
                    personStateOfLegal = legalState.illegalSuitCase;
                    break;
                case 3:
                    personStateOfLegal = legalState.illegalJob;
                    break;
            }
        }
        else
        {
            personStateOfLegal = legalState.legal;
        }
    }
}