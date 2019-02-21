using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Respawner : MonoBehaviour
{
	public GameObject splash;
    public GameObject spawnPoint;
    public GameObject player;
    public string playerTag = "player1";
    private string killBar = "Respawner";
    public int spawnX = 0;
    public int spawnY = 0;
    public int spawnZ = 0;



    void OnCollisionEnter2D(Collider2D col)
	{
        // If the player hits the trigger...
        if (col.gameObject.CompareTag("Respawn"))
        {
            // .. stop the camera tracking the player


            // .. stop the Health Bar following the player
            if (GameObject.FindGameObjectWithTag("HealthBar").activeSelf)
            {
                GameObject.FindGameObjectWithTag("HealthBar").SetActive(false);
            }

            Debug.Log("Player Contact");
            // ... destroy the player.
            Destroy(player);
            // ... reload the level.
            WaitToLoad();
            Vector2 vec = new Vector2(spawnX, spawnY);
            player.transform.position = vec;

        }
	}

	IEnumerator WaitToLoad()
	{
        // ... pause briefly
        yield return new WaitForSeconds(2);
       
	}
}
