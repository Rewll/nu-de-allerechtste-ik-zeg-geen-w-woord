using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamenLijstScript : MonoBehaviour
{
    public GameManager gm;
    public GameObject textPrefab;
    public Transform firstTextPos;

    public float yOffsetAmount;
    private float yOffset;
    private float xOffset;
    public float xOffsetAmount;

    public int maxVerticaalNamen;
    private int maxVerticaalHoeveelheid;


    void Start()
    {
        maxVerticaalHoeveelheid = maxVerticaalNamen;
        lijstGeneren2();
    }

    void lijstGeneren()
    {
        for (int i = 0; i < gm.gekozenNamenLijst.Count; i++)
        {
            GameObject newText = Instantiate(textPrefab, new Vector3(firstTextPos.position.x, firstTextPos.position.y - yOffset, transform.position.z), Quaternion.identity);
            newText.transform.SetParent(transform);
            newText.transform.localScale = new Vector3(.3f, .2f, 1);
            newText.GetComponent<Text>().text = gm.gekozenNamenLijst[i];
            yOffset += yOffsetAmount;
        }
    }

    void lijstGeneren2()
    {
        for (int i = 0; i < gm.gekozenNamenLijst.Count; i++)
        {
            if (i == maxVerticaalHoeveelheid)
            {
                xOffset += xOffsetAmount;
                yOffset = 0;
                maxVerticaalHoeveelheid += maxVerticaalNamen;
            }
            GameObject newText = Instantiate(textPrefab, new Vector3(firstTextPos.position.x + xOffset, firstTextPos.position.y - yOffset, transform.position.z), Quaternion.identity);
            newText.transform.SetParent(transform);
            newText.transform.localScale = new Vector3(.3f, .2f, 1);
            newText.GetComponent<Text>().text = gm.gekozenNamenLijst[i];
            yOffset += yOffsetAmount;
        }
    }

}
