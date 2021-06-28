using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {

            Instantiate(enemy, transform.position + new Vector3(Random.Range(-2.5f, 2.5f), 0, 0), Quaternion.identity);
        }
    }
}