using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briefcase : MonoBehaviour
{
    [SerializeField] private PersonGenration PersonScript;
    [SerializeField] private GameManager GameManager;
    [SerializeField] private int AmountOfItems;
    [SerializeField] private float Speed;
    private bool stop;
    private void Start()
    {
        transform.position = new Vector3(-12, 0, 0);
        GenerateNewBriefcase();
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed, transform.position.y, transform.position.z);
    }

    public void GenerateNewBriefcase()
    {
        Debug.Log(PersonScript.personStateOfLegal.ToString());
        if (PersonScript.personStateOfLegal.ToString() == "illegalSuitCase")
        {
            Instantiate(GameManager.AlleIllegalIitems[Random.Range(0, GameManager.AlleIllegalIitems.Count)], transform);
            for (int i = 0; i < AmountOfItems -1; i++)
            {
                Instantiate(GameManager.AlleLegalItems[Random.Range(0, GameManager.AlleLegalItems.Count)], transform);
            }
        }
        else
        {
            for (int i = 0; i < AmountOfItems; i++)
            {
                Instantiate(GameManager.AlleLegalItems[Random.Range(0, GameManager.AlleLegalItems.Count)], transform);
            }
        }


    }
}
