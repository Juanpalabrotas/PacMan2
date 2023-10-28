using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el jugador esté etiquetado como "Player"
        {
            GameObject gameManager = GameObject.FindWithTag("GameManager");
            if (gameManager != null)
            {
                gameManager.SendMessage("PointCollected");
                Destroy(gameObject); // Elimina el punto después de recogerlo
            }
        }
    }
}
