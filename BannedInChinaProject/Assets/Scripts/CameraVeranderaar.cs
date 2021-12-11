using UnityEngine;
using Cinemachine;

public class CameraVeranderaar : MonoBehaviour
{
    public GameObject bureau, koffer, persoon;

    public void BureauZicht()
    {
        bureau.SetActive(true);
        koffer.SetActive(false);
        persoon.SetActive(false);
    }

    public void SelecteerPersoonZicht()
    {
        bureau.SetActive(false);
        koffer.SetActive(false);
        persoon.SetActive(true);
    }

    public void SelecteerKofferZicht()
    {
        bureau.SetActive(false);
        koffer.SetActive(true);
        persoon.SetActive(false);
    }
}