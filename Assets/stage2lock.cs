using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2lock : MonoBehaviour
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
        if (PlayerAttributes.stage1 == true)
        {
            animator.SetBool("stage2", true);
        }
        else
        {
            animator.SetBool("stage2", false);
        }
    }
}
