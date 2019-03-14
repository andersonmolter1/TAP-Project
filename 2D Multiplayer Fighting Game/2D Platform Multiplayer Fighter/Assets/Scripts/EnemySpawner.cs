using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject healer;
    public float spawnTime = 1000.0f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    

    void Start()
    {
        InvokeRepeating("HealerSpawn", 5, 0);
        InvokeRepeating("EnemySpawn", 5, 0);
    }

    
    void EnemySpawn()
    {

        
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    void HealerSpawn()
    {
        
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(healer, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}