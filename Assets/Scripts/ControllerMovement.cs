using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerMovement : MonoBehaviour
{
    public int playerNumber;

    public string horizontalAxis;
    public string verticalAxis;
    public string rotateAxis;

    private Rigidbody2D rb;
    private float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis(horizontalAxis);
        float moveVertical = Input.GetAxis(verticalAxis);
        float rotateInput = Input.GetAxis(rotateAxis);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * moveSpeed;

        if (Mathf.Abs(rotateInput) > 0.1f)
        {
            float rotationAmount = rotateInput * rotationSpeed * Time.fixedDeltaTime;
            rb.rotation += rotationAmount;
        }
    }
}