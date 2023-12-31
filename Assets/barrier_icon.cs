using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_icon : MonoBehaviour
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
        if (PlayerAttributes.CanUseBarrier == true)
        {
            animator.SetBool("CanUseBarrier", true);
        }
        else
        {
            animator.SetBool("CanUseBarrier", false);
        }
    }
}
