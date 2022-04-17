using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float SpawnRange = 8.5f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-SpawnRange, SpawnRange);
        float zPos = Random.Range(-SpawnRange, SpawnRange);
        Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos);
        return spawnPos;
    }

}
