using UnityEngine;

public class SpawnSpawnTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    
    public GameObject ObjectToSpawn;

    public Vector3 spawnPosition;

    void Start()
    {
        Instantiate(ObjectToSpawn, spawnPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
