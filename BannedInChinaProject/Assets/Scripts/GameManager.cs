using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public List<GameObject> Personen = new List<GameObject>();

    public int mensenAantal;
    public List<string> namenLijst = new List<string>();

    public List<string> alleVoorNamen = new List<string>();
    public List<string> alleAchterNamen = new List<string>();
    public List<string> alleBeroepen = new List<string>();


    public List<GameObject> legalItems = new List<GameObject>();
    public List<GameObject> illegalItems = new List<GameObject>();


    void Start()
    {
        genereerLijst();
    }
    //wist je da thg
    void genereerLijst()
    {
        while (namenLijst.Count != mensenAantal)
        {
            string name = alleVoorNamen[Random.Range(0, alleVoorNamen.Count)] + " " +
              alleAchterNamen[Random.Range(0, alleAchterNamen.Count)];
            if (!namenLijst.Contains(name))
            {
                namenLijst.Add(name);
            } 
        }
    }
}