using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Respawner : MonoBehaviour
{
    
    public Transform spawnPoint;
    public GameObject player;

    void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.CompareTag("killBar"))
        {
            Debug.Log("Killbar");
            killPlayer();
        }
	}
    public void killPlayer()
    {
         player.transform.position = spawnPoint.transform.position;
    }
}
