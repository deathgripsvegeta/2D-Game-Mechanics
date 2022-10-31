using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float XRange = 6.27f;
    public float YRange = 3.11f;
    public int EnemyCount;
    public int WaveCount = 1;
    // Start is called before the first frame update
    void Start()
    {
       SpawnEnemyWave(WaveCount);
        //Instantiate(EnemyPrefab, GenerateSpawnPosition(), EnemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyCount = FindObjectsOfType<Enemy>().Length;
        if(EnemyCount == 0)
        {
            WaveCount++; // WaveCount = WaveCount + 1;
            SpawnEnemyWave(WaveCount);
        }
    }
    private Vector2 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-XRange, XRange);
        float spawnPosY = Random.Range(-YRange, YRange);
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);
        return randomPos;
    }
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(EnemyPrefab, GenerateSpawnPosition(), EnemyPrefab.transform.rotation);

        }
        
    }
    
}
