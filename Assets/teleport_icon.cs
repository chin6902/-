using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_icon : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.CanDash == true)
        {
            animator.SetBool("CanDash", true);
        }
        else
        {
            animator.SetBool("CanDash", false);
        }
    }
}
