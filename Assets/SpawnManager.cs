using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public float xPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(-xPosition, xPosition);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
    void StartSpawn()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }
    public void StopSpawn()
    {

    }
}
