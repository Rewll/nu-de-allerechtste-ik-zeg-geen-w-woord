using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEndEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent AnimationEventTriggered;
    [SerializeField] private UnityEvent StartAnimationEventTriggered;

    public void TriggerEvent()
    {
        AnimationEventTriggered.Invoke();
    }
    public void AnimationStartTriggerEvent() 
    {
        StartAnimationEventTriggered.Invoke();
    }
}
