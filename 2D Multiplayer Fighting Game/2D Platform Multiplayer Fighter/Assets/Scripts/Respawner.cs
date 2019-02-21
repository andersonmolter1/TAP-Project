using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Respawner : MonoBehaviour
{
    public float spawnX = 0f;
    public float spawnY = 0f;
    public GameObject spawnPoint;



    void OnCollisionEnter2D(Collision2D col)
	{
        //Compiler says there is an error on 16 but spawn point is referenced in inspector.
        //player still spawns properly. So will ignore error for now. 
        Vector2 spawnSpot = spawnPoint.transform.position;
        // If the player hits the trigger...
        if (col.gameObject.CompareTag("Respawn"))
        {
            // .. stop the camera tracking the player


            // .. stop the Health Bar following the player3
            /*
            if (GameObject.FindGameObjectWithTag("HealthBar").activeSelf)
            {
                GameObject.FindGameObjectWithTag("HealthBar").SetActive(false);
            }
            */
            transform.position = spawnSpot;

            
            
            

        }
	}

	IEnumerator WaitToLoad()
	{
        // ... pause briefly
        yield return new WaitForSeconds(2);
       
	}
}
