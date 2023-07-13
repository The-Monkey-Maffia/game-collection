using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controllerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody rb;
    public float dashCooldown = 2f;
    public float knockbackForce = 3f;
    public float dashKnockbackForce = 6f;

    private float xInput;
    private float yInput;


    // Start is called as you start the game, we use it to initially give values to things
    void Start()
    {
        Debug.Log(Gamepad.all.Count);
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        movementControllerPlayer1();
        ProcessInputs();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void movementControllerPlayer1()
    {
        if (Gamepad.all.Count > 0)
        {
            rb.AddForce(new Vector3(xInput, 0f, -yInput) * movementSpeed);
            dashCooldown -= Time.deltaTime;

            if (Gamepad.all[0].aButton.isPressed && dashCooldown <= 0)
            {
                dashCooldown = 2f;
                rb.AddForce(new Vector3(xInput, 0f, -yInput) * 200);
            }

            if (Gamepad.all[0].startButton.isPressed)
            {
                if (gameIsPaused)
                {
                    /* resume(); */
                } else
                {
                    /* pause(); */
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = collision.contacts[0].point - transform.position;
            direction = direction.normalized;

            // Apply knockback force to the other ball
            

            if (dashCooldown >= 1)
            {
                otherRb.AddForce(direction * dashKnockbackForce, ForceMode.Impulse);

            }
            else
            {
                otherRb.AddForce(direction * knockbackForce, ForceMode.Impulse);
            }
        }
    }

}
