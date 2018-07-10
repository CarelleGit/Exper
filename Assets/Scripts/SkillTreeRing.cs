using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeRing : MonoBehaviour
{
    [SerializeField]
    private GameObject skillTreeRing;
    public string layer;
    private Ray ray;
    private RaycastHit2D raycast;

    private Vector2 skillTree;

    private bool isTrue = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isTrue)
            {
                ActivateSkillTree();
            }
            else
            {
                DeactivateSkillTree();
            }
        }
    }

    void ActivateSkillTree() //sets the GameObject true
    {
        skillTreeRing.SetActive(true);
        isTrue = true;

    }
    void DeactivateSkillTree() //sets the GameObject false
    {
        skillTreeRing.SetActive(false);
        isTrue = false;
    }
}
