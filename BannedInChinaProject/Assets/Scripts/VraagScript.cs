using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class VraagScript : MonoBehaviour
{
    [SerializeField]
    PersonGenration pg;
    public int spraakOnderdeel;
    [TextArea]
    public List<string> spraakTekstenErvoor = new List<string>();
    //public string BaanErvoorTekst;
    //public string NaamErvoorTekst;
    public Text spraakTekst;
    //public Text knopTekst;
    public GameObject spraakbubbel;
    public UnityEvent mondBeweging;

    private void Start()
    {
        checkSpraakOnderdeel();
    }


    public void Praat()
    {
        spraakOnderdeel++;
        checkSpraakOnderdeel();
        if (spraakOnderdeel >= spraakTekstenErvoor.Count)
        {
            spraakOnderdeel = 0;
        }
    }

    void checkSpraakOnderdeel()
    {
        switch (spraakOnderdeel)
        {
            case 0:
                spraakbubbel.SetActive(false);
                break;
            case 1:
                spraakbubbel.SetActive(true);
                spraakTekst.text = spraakTekstenErvoor[0] + pg.PersonName;
                //knopTekst.text = "What is your Job?";
                mondBeweging.Invoke();
                break;
            case 2:
                spraakTekst.text = spraakTekstenErvoor[1] + pg.Job;
                //knopTekst.text = "What is your name?";
                mondBeweging.Invoke();
                break;
        }
    }
}