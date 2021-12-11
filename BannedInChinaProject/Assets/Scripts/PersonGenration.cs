using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PersonGenration : MonoBehaviour
{
    public GameManager gm;
    public string PersonName;
    public string Job;
    public enum legalState { legal, illegalName, illegalSuitCase, illegalJob}
    public legalState personStateOfLegal;
    public int illegalChance;
    public TMP_Text personNameText;
    public TMP_Text jobText;

    void Start()
    {
        generatePerson();
    }

    public void generatePerson()
    {
        Job = gm.alleBeroepen[Random.Range(0, gm.alleBeroepen.Count)];
        jobText.text = Job;

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


        gm.legalityText.text = personStateOfLegal.ToString();
        personNameText.text = PersonName;
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