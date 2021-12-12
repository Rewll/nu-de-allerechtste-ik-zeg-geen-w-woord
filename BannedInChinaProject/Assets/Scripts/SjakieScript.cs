using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SjakieScript : MonoBehaviour
{
    public UnityEvent HetSjakieEvent;
    public void SjakieTijd()
    {
        HetSjakieEvent.Invoke();
    }

}
