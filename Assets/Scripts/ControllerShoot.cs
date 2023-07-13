using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    public string shootButton;

    private void Start()
    {
        int playerNumber = GetComponent<ControllerMovement>().playerNumber;

        shootButton = "Shoot_" + playerNumber;
    }

    private void Update()
    {
        if (Input.GetButtonDown(shootButton))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.velocity = firePoint.up * bulletSpeed;
    }
}
