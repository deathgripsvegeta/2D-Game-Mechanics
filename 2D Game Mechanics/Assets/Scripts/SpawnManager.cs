using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float XRange = 6.27f;
    public float YRange = 3.11f;
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-XRange, XRange);
        float spawnPosY = Random.Range(-YRange, YRange);
        Instantiate(EnemyPrefab, new Vector3(spawnPosX, spawnPosY), EnemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
