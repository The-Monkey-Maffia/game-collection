using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controllerMovement2 : MonoBehaviour
{
    public float movementSpeed = 0.8f;
    public Rigidbody rb;
    public float dashCooldown = 2f;
    public float knockbackForce = 3f;
    public float dashKnockbackForce = 6f;


    private float xInput;
    private float yInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementControllerPlayer2();
        ProcessInputs2();
    }

    private void ProcessInputs2()
    {
        xInput = Input.GetAxis("Horizontal2");
        yInput = Input.GetAxis("Vertical2");
    }

    private void movementControllerPlayer2()
    {
        if (Gamepad.all.Count > 0)
        {
            rb.AddForce(new Vector3(xInput, 0f, -yInput) * movementSpeed);
            dashCooldown -= Time.deltaTime;

            if (Gamepad.all[0].aButton.isPressed && dashCooldown <= 0)
            {
                dashCooldown = 2f;
                rb.AddForce(new Vector3(xInput, 0f, -yInput) * 300);
            }

            if (Gamepad.all[0].startButton.isPressed)
            {
                Debug.Log("PAUSE MENU");
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
            otherRb.AddForce(direction * knockbackForce, ForceMode.Impulse);

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
