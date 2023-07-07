using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    PlayerControls controls;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce;

    void Update()
    {
        controls.Shooting.Shoot.performed += ctx => shoot();
    }

    void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Shooting.Enable();
    }

    private void OnDisable()
    {
        controls.Shooting.Disable();
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
