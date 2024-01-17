using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport_icon : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

   
    // Update is called once per frame
    void Update()
    {
        if (playerController.CanDash == true)
        {
            animator.SetBool("CanDash", true);
        }
        else
        {
            animator.SetBool("CanDash", false);
        }
    }
}
