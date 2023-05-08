using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
        for(int i = 0; i < 3; i++) {
           Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), (float).50, Random.Range(-9, 10));
           Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
