using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegelboekLijst : MonoBehaviour
{
    public GameManager gm;
    public GameObject textPrefab;
    public Transform EersteTextLinks;
    public Transform EersteTextRechts;
    string NameOfList;
    public List<List<string>> lijstVanLijsten = new List<List<string>>();
    public int maxPerLijstAantal;
    private int maxPerPaginaAantal;
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
        instantiateText(lijstVanLijsten[CurrentPage], EersteTextRechts);
        Debug.Log(name + " " + lijstVanLijsten.Count);
    }

    public void volgendePaginas()
    {
        deleteText();
        CurrentPage += 2;
        if (CurrentPage == 0)
        {
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextRechts);
        }
        else if (CurrentPage == lijstVanLijsten.Count)
        {
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextLinks);
        }
        else
        {
            instantiateText(lijstVanLijsten[CurrentPage - 1], EersteTextLinks);
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextRechts);
        }

    }

    public void vorigePaginas()
    {
        deleteText();
        CurrentPage -= 2;
        if (CurrentPage == 0)
        {
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextRechts);
        }
        else if (CurrentPage == lijstVanLijsten.Count)
        {
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextLinks);
        }
        else
        {
            instantiateText(lijstVanLijsten[CurrentPage - 1], EersteTextLinks);
            instantiateText(lijstVanLijsten[CurrentPage], EersteTextRechts);
        }
    }

    void generateLists()
    {
        for (int i = 0; i < Mathf.Round(gm.regels.Count / maxPerLijstAantal); i++)
        {
            lijstVanLijsten.Add(new List<string>());
            for (int j = 0; j < maxPerLijstAantal; j++)
            {
                lijstVanLijsten[i].Add(gm.regels[j + (maxPerLijstAantal * i)]);
            }
        }

        if (gm.regels.Count % maxPerLijstAantal != 0)
        {
            lijstVanLijsten.Add(new List<string>());
            for (int i = 0; i < gm.regels.Count % maxPerLijstAantal; i++)
            {
                lijstVanLijsten[lijstVanLijsten.Count - 1].Add(gm.regels[i + (maxPerLijstAantal * (lijstVanLijsten.Count - 1))]);
            }
        }
    }

    void instantiateText(List<string> listOfList, Transform firstTextPos)
    {
        yOffset = 0;
        for (int i = 0; i < listOfList.Count; i++)
        {
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