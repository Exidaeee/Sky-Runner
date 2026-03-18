using System;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab;
    public float Ymax = 2f;
    public float Ymin = -2f;
    public float Xspawn = 8f; 
    public float spawnRate = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnBird), 1f,spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBird()
    {    
         float randomY = UnityEngine.Random.Range(Ymin, Ymax);
         Vector2 spawnPos = new Vector2(Xspawn, randomY);
         Instantiate(birdPrefab, spawnPos, Quaternion.identity);
        
    }
}
