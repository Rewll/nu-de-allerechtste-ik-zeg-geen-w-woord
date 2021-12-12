using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobCardScript : MonoBehaviour
{
    [SerializeField] private PersonGenration person;
    public GameManager gameManager;
    [SerializeField] private Text name;
    [SerializeField] private Text job;
    [SerializeField] private int JobLieChance;
    [SerializeField] private int NameLieChance;
    private int TotalLieChance;
    public void GenerateJobCard()
    {
        if (person.personStateOfLegal.ToString() == "illegalJob") 
        {
            TotalLieChance = JobLieChance + NameLieChance;
            int randomInt = Random.Range(1, TotalLieChance);
            if (randomInt <= NameLieChance && NameLieChance != 0)
            {
                string fakeName;
                do
                {
                    fakeName = gameManager.alleVoorNamen[Random.Range(0, gameManager.alleVoorNamen.Count)] + " " + gameManager.alleAchterNamen[Random.Range(0, gameManager.alleAchterNamen.Count)]; ;
                } while (fakeName == person.name ||!gameManager.gekozenNamenLijst.Contains(fakeName));
                name.text = fakeName;
                job.text = person.Job;
            }
            else if (randomInt <= JobLieChance + NameLieChance && JobLieChance != 0)
            {
                string fakeJob;
                do
                {
                    fakeJob = gameManager.alleBeroepen[Random.Range(0, gameManager.alleBeroepen.Count)];
                } while (fakeJob == person.Job);
                name.text = person.PersonName;
                job.text = fakeJob;
            }
            else 
            {
                Debug.LogWarning("Both Job and Name lie Chance is 0");
            }

        }
        else
        {
            name.text = person.PersonName;
            job.text = person.Job;
        }
    }
}
