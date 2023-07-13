using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float threshold;
    public Transform respawnPoint;
    public int lives = 3;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(transform.position.y < threshold && lives > 0)
        {
            lives -= 1;
            transform.position = new Vector3(respawnPoint.position.x, respawnPoint.position.y, respawnPoint.position.z);
        }
    }
}
