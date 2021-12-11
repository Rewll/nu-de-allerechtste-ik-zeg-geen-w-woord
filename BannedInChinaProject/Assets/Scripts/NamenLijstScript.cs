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

    void Start()
    {
        lijstGeneren();
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
}
