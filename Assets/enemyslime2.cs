using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyslime2 : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the slime moves
    private bool moveUp = true; // Determines the initial direction

    private Animator animator; // Reference to the Animator component

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the same GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            animator.SetFloat("Vertical", 0);
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
            animator.SetFloat("Vertical", 1);
        }

        // Check if the slime should change direction
        if (transform.position.y > 20f)
        {
            moveUp = false;
        }
        else if (transform.position.y < -3f)
        {
            moveUp = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Debug log to verify item pickup
            Debug.Log("Enemy");

            // Access the PlayerController2 script of the player
            PlayerController2 playerController = other.GetComponent<PlayerController2>();

            // Check if the playerController is not null (to avoid errors)
            if (playerController != null)
            {
                // Move the player back to the starting position
                other.transform.position = playerController.startingPosition;

                // You can also reload the scene if needed
                // SceneManager.LoadScene(scenename);
            }
        }
    }
}
