using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float obstacleSpeed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,0,obstacleSpeed));
    }
    private void OnBecameInvisible()
    {
        
    }
}
