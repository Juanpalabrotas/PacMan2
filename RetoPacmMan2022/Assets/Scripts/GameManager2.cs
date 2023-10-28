using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public GameObject doorToDisable;  // Arrastra el GameObject de la puerta a través del inspector
    public int totalPoints = 10;      // Establece la cantidad total de puntos a recoger

    private int collectedPoints = 0;

    

    // Llamado cuando un punto es recogido
    public void PointCollected()
    {
        collectedPoints++;

        if (collectedPoints >= totalPoints)
        {
            // Desactivar la puerta
            doorToDisable.GetComponent<Animator>().SetBool("Gano",true);
        }
    }

   
}
