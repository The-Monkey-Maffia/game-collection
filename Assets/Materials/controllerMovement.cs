using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controllerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody rb;
    public float dashCooldown = 2f;

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
                Debug.Log("PAUSE MENU");
            }
        }
    }
}
