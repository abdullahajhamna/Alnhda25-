using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectNew : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter(Collider other)
    {
        // Check if the player has collided with the coin
        if (other.CompareTag("Player"))
        {
            // Add to the player's score (assuming you have a score manager)
            ScoreManager.instance.AddScore(coinValue);

            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
