using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class Perdio : MonoBehaviour
{
    public string sceneToLoad;
    public int currentLives;
    int maxLives = 3;
    public Image[] lifeImages;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }


  

}
