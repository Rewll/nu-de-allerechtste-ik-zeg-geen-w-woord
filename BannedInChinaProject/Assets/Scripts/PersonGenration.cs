using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonGenration : MonoBehaviour
{
    public string PersonName;
    public string Job;
    public enum legalState { legal, illegalName, illegalSuitCase, illegalJob}
    public legalState personStateOfLegal;
    public float illegalChance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generatePerson()
    {
        if (Random.Range(1, illegalChance) == 1)
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
