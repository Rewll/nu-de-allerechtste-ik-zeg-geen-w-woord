using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinFlipScript : MonoBehaviour
{
    [SerializeField] private UnityEvent Heads;
    [SerializeField] private UnityEvent Tails;
    public void TossCoin()
    {
        int flip = Random.RandomRange(0, 2);
        if(flip == 1)
        {
            Heads.Invoke();
        }
        else if(flip == 0)
        {
            Tails.Invoke();
        }
        else
        {
            Debug.Log("Landed on its side");
        }
    }

}
