using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public GameManager gm;
    public PersonGenration pg;
    public UnityEvent newPerson;

    public void legal()
    {
        if (pg.personStateOfLegal.ToString() == "legal") //Goed geantwoord
        {
            gm.socialCreditScoreTest += 2;
        }
        else //Slecht geantwoord
        {
            gm.socialCreditScoreTest -= 10;
        }
        newPerson.Invoke();
        //Debug.Log(gm.socialCreditScoreTest);
    }

    public void illegal()
    {
        if (pg.personStateOfLegal.ToString() != "legal") //Goed geantwoord
        {
            gm.socialCreditScoreTest += 2;
        }
        else //Slecht geantwoord
        {
            gm.socialCreditScoreTest -= 10;
        }
        newPerson.Invoke();
        //Debug.Log(gm.socialCreditScoreTest);
    }
}
