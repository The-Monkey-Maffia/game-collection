using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject player1Object;
    GameObject player2Object;

    public void Start()
    {
        player1Object = GameObject.Find("Player1");
        player2Object = GameObject.Find("Player2");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletP1"))
        {
            player1Object.GetComponent<ScoreManager1>().AddPoint1(1);
            Explode();
        }

        if (collision.CompareTag("BulletP2"))
        {
            player2Object.GetComponent<ScoreManager1>().AddPoint2(1);
            Explode();
        }
    }

    private void Explode()
    {
        Destroy(gameObject);
    }
}
