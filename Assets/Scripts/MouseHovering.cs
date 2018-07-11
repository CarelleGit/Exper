using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHovering : MonoBehaviour
{
    [SerializeField]
    private Animator Skills;

    private void OnMouseOver()
    {
        Skills.SetTrigger("Selection");
    }
    private void OnMouseExit()
    {
        Skills.SetTrigger("Deselection");
    }
}
    