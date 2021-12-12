using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamenLijstGeneratie : MonoBehaviour
{
    public GameManager gm;
    public GameObject textPrefab;
    public Transform firstTextPos;
    string NameOfList;
    public List<List<string>> lijstVanLijsten = new List<List<string>>();
    public int maxPerLijstAantal;
    public int maxPerPaginaAantal;
    private int maxPerPaginaAantalBijgehouden;
    [Space]
    public float yOffsetAmount;
    private float yOffset;
    private float xOffset;
    public float xOffsetAmount;
    public int CurrentPage; 
    [Space]
    public GameObject parentOfTextItems;

    private void Start()
    {
        maxPerPaginaAantalBijgehouden = maxPerPaginaAantal;

        generateLists();
        instantiateText(lijstVanLijsten[CurrentPage]);
    }

    public void volgendePagina()
    {
        deleteText();
        CurrentPage++;
        Debug.Log(lijstVanLijsten[CurrentPage][4]);
        instantiateText(lijstVanLijsten[CurrentPage]);
    }

    public void vorigePagina()
    {
        deleteText();
        CurrentPage--;
        instantiateText(lijstVanLijsten[CurrentPage]);
    }


    void generateLists()
    {
        for (int i = 0; i < Mathf.Round(gm.gekozenNamenLijst.Count / maxPerLijstAantal); i++)
        {
            lijstVanLijsten.Add(new List<string>());
            for (int j = 0; j < maxPerLijstAantal; j++)
            {
                lijstVanLijsten[i].Add(gm.gekozenNamenLijst[j + (maxPerLijstAantal * i)]);
            }
        }

        if (gm.gekozenNamenLijst.Count % maxPerLijstAantal != 0)
        {
            lijstVanLijsten.Add(new List<string>());
            for (int i = 0; i < gm.gekozenNamenLijst.Count % maxPerLijstAantal; i++)
            {
                lijstVanLijsten[lijstVanLijsten.Count -1].Add(gm.gekozenNamenLijst[i + (maxPerLijstAantal * (lijstVanLijsten.Count - 1))]);
            }
        }

    }

    void instantiateText(List<string> listOfList)
    {
        for (int i = 0; i < listOfList.Count; i++)
        {
            if (i == maxPerPaginaAantalBijgehouden)
            {
                xOffset += xOffsetAmount;
                yOffset = 0;
                maxPerPaginaAantalBijgehouden += maxPerPaginaAantal;
            }
            GameObject newText = Instantiate(textPrefab, new Vector3(firstTextPos.position.x + xOffset, firstTextPos.position.y - yOffset, transform.position.z), Quaternion.identity);
            newText.transform.SetParent(parentOfTextItems.transform);
            newText.transform.localScale = new Vector3(.3f, .2f, 1);
            newText.GetComponent<Text>().text = listOfList[i];
            yOffset += yOffsetAmount;
        }
    }

    void deleteText()
    {
        yOffset = 0;
        xOffset = 0;
        maxPerPaginaAantalBijgehouden = maxPerPaginaAantal;
        foreach (Transform child in parentOfTextItems.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}