using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate de que el jugador est� etiquetado como "Player"
        {
            GameObject gameManager = GameObject.FindWithTag("GameManager");
            if (gameManager != null)
            {
                gameManager.SendMessage("PointCollected");
                Destroy(gameObject); // Elimina el punto despu�s de recogerlo
            }
        }
    }
}
