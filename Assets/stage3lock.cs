using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3lock : MonoBehaviour
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
        if (PlayerAttributes.stage2 == true)
        {
            animator.SetBool("stage3", true);
        }
        else
        {
            animator.SetBool("stage3", false);
        }
    }
}
