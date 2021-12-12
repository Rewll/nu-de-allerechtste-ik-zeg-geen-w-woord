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
    [SerializeField] private GameObject parentOfItems;
    [SerializeField] private bool firstTime;
    private bool stop;
    private void Start()
    {
        firstTime = true;
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
        if (!firstTime)
        {
            foreach (Transform child in parentOfItems.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
        else if (firstTime)
        {
            firstTime = false;
        }

        if (PersonScript.personStateOfLegal.ToString() == "illegalSuitCase")
        {
            GameObject newIllegalItem = Instantiate(GameManager.AlleIllegalIitems[Random.Range(0, GameManager.AlleIllegalIitems.Count)], transform);
            newIllegalItem.transform.SetParent(parentOfItems.transform);
            for (int i = 0; i < AmountOfItems -1; i++)
            {
                GameObject newLegalItem = Instantiate(GameManager.AlleLegalItems[Random.Range(0, GameManager.AlleLegalItems.Count)], transform);
                newLegalItem.transform.SetParent(parentOfItems.transform);
            }
        }
        else
        {
            for (int i = 0; i < AmountOfItems; i++)
            {
                GameObject newLegalItem = Instantiate(GameManager.AlleLegalItems[Random.Range(0, GameManager.AlleLegalItems.Count)], transform);
                newLegalItem.transform.SetParent(parentOfItems.transform);
            }
        }

        Speed = StartSpeed;
        transform.position = new Vector3(SuitcaseStartX, YPos, transform.position.z);
    }
}
