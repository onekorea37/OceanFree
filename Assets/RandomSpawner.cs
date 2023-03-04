using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject spherePrefab;
    public float minX = -9, maxX = 9, minY = -4, maxY =0;
    public float minSpawnInterval = 10, maxSpwanInterval = 20;


    void Start()
    {
        StartCoroutine(SpawnBlocks());
    }

    IEnumerator SpawnBlocks() 
    {
        while(true) 
        {
            Vector2 randomPosition = new Vector2(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY)
            ); 

            Instantiate(spherePrefab, randomPosition, Quaternion.identity);

        
            yield return new WaitForSeconds(Random.Range(minSpawnInterval, maxSpwanInterval));
        }
    }

    void Update()
    {
        
    }
}