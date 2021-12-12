using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventTest : MonoBehaviour
{
    // Start is called before the first frame update
    public void Test()
    {
        Debug.Log("EventTriggerd Activated");
    }

    public void TestStringInput(string input)
    {
        Debug.Log("The String " + input + " Was Found!");
    }
}
