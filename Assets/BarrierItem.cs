using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierItem : MonoBehaviour
{
    // Called when the item comes in contact with the player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Debug log to verify item pickup
            Debug.Log("Item picked up!");

            // Destroy the item
            Destroy(gameObject);
            PlayerAttributes.stage2 = true;


            // Load the next scene
            SceneManager.LoadSceneAsync("skill2");
        }
    }

}
