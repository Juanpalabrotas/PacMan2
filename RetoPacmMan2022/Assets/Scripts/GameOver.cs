using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{ 

    
    public int currentLives;
    public int maxLives = 3;
    public Image[] lifeImages; // Arreglo de imágenes que representan las vidas
    public GameObject panelPerdio;
    public AudioSource audioSource;
    public AudioClip audioClipPerdio;

        
    private void Start()
    {
        currentLives = maxLives;
        UpdateLivesUI();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            // Desactivar el jugador
            gameObject.SetActive(false);

            // Mostrar el texto "GAME OVER"
            //gameOverText.text = "GAME OVER";
            //gameOverText.gameObject.SetActive(true);

            currentLives--;
            UpdateLivesUI();
        }
    }
    private void UpdateLivesUI() 
    {
        // Activa o desactiva las imágenes de las vidas en la interfaz de usuario según las vidas actuales.
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < currentLives)
            {
                lifeImages[i].enabled = true;
            }
            else
            {
                lifeImages[i].enabled = false;
            }
        }
        if (currentLives == 0)
        {
            panelPerdio .SetActive(true);
            audioSource.clip = audioClipPerdio;
            audioSource.Play();

        }
    }

}
