using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemycontroller2 : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 initialDirection;
    public string scenename;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialDirection = new Vector2(0, -1); // â∫ï˚å¸Ç…êiÇﬁÇÊÇ§Ç…ê›íË
    }

    private void FixedUpdate()
    {
        MoveStraight();
    }

    private void MoveStraight()
    {
        // Move in the initial direction.
        rb.velocity = initialDirection * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy collided with Player");
            PlayerAttributes.health -= 50;
            Destroy(gameObject);

            if (PlayerAttributes.health < 1)
            {
                SceneManager.LoadScene(scenename);
            }
        }
    }

    private void OnBecameInvisible()
    {
        // If the enemy goes off-screen, destroy it.
        Destroy(gameObject);
    }
}