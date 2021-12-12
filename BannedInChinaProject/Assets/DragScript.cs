using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    [SerializeField] private Transform Middel;
    private bool draggable = true;
    [SerializeField] private Camera BereauCamera;
    private Vector3 Ofset;

    private void OnMouseDown()
    {
        Ofset = Middel.position - BereauCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        if (draggable) 
        {
            Middel.transform.position = new Vector3(BereauCamera.ScreenToWorldPoint(Input.mousePosition).x + Ofset.x, BereauCamera.ScreenToWorldPoint(Input.mousePosition).y + Ofset.y,0); 
        }
    }

}
