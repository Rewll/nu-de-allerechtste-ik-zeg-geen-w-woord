using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briefcase : MonoBehaviour
{
    [SerializeField] private PersonGenration PersonScript;
    [SerializeField] private GameManager GameManager;
    [SerializeField] private int AmountOfItems;
    [SerializeField] private float Speed;
    [SerializeField] private int SuitcaseStartX;
    [SerializeField] private int SuitcaseEndX;
    [SerializeField] private float StartSpeed;
    [SerializeField] private float YPos;
    private bool stop;
    private void Start()
    {
        transform.position = new Vector3(SuitcaseStartX,YPos, transform.position.z);
        GenerateNewBriefcase();
    }

    public void ChangeSpeed(float newSpeed)
    {
        Speed = newSpeed;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
        if(transform.position.x >= SuitcaseEndX)
        {
            Speed = 0;
        }
    }

    public void GenerateNewBriefcase()
    {
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

        Speed = StartSpeed;
    }
}
