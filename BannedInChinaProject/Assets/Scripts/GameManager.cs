using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public PersonGenration pg;
    public enum legalState { legal, illegalName, illegalSuitCase, illegalJob }
    public int mensenAantal;
    public GameObject currentPerson;
    public int socialCreditScoreTest;
    private string playerInput;
    [Space]
    public List<string> gekozenNamenLijst = new List<string>();
    [TextArea]
    public List<string> regels = new List<string>();
    [Space]
    public List<string> alleVoorNamen = new List<string>();
    public List<string> alleAchterNamen = new List<string>();
    public List<string> alleBeroepen = new List<string>();
    public List<GameObject> AlleIllegalIitems = new List<GameObject>();
    public List<GameObject> AlleLegalItems = new List<GameObject>();
    public List<GameObject> AllFaces = new List<GameObject>();
    public UnityEvent <string> score;

    void Start()
    {
        genereerLijst();
    }

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

    public void scoreSchrijven()
    {
        score.Invoke(socialCreditScoreTest.ToString());
    }
}