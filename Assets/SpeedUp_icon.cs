using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp_icon : MonoBehaviour
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
        if (PlayerAttributes.CanSpeedUp == true)
        {
            animator.SetBool("SpeedUp", true);
        }
        else
        {
            animator.SetBool("SpeedUp", false);
        }
    }
}
