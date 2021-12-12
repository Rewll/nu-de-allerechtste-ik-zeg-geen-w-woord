using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    [SerializeField] private Transform ObjectMiddle;
    private bool draggable = true;
    [SerializeField] private Camera BereauCamera;
    private Vector3 Ofset;
    [SerializeField] private Transform Corner1;
    [SerializeField] private Transform Corner2;


    private void OnMouseDown()
    {
        Ofset = ObjectMiddle.position - BereauCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        if (draggable) 
        {
            ObjectMiddle.transform.position = new Vector3(Mathf.Clamp(BereauCamera.ScreenToWorldPoint(Input.mousePosition).x + Ofset.x,Corner1.position.x,Corner2.position.x), Mathf.Clamp(BereauCamera.ScreenToWorldPoint(Input.mousePosition).y + Ofset.y,Corner2.position.y,Corner1.position.y),0); 
        }
    }

}
