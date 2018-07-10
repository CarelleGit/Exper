using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHovering : MonoBehaviour
{

    private void OnPointerEnter()
    {
        Debug.Log(gameObject.name + " Detected");
    }
    private void OnMouseExit()
    {
        Debug.Log(gameObject.name + " Lost");
    }
}
    