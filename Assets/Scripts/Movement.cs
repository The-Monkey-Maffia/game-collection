using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    PlayerControls controls;
    public float RotationSpeed = 0.4f;

    Vector2 move;
    Vector2 rotate;
    public float speed;

    public Rigidbody2D rb;


    void Awake()
    {
        controls = new PlayerControls();

        controls.Movement.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Movement.Move.canceled += ctx => move = Vector2.zero;

        controls.Movement.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
    }

    void Update()
    {
        rb.velocity = new Vector2((move.x * speed), (move.y * speed));

        Vector2 lookDir = rotate;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void OnEnable()
    {
        controls.Movement.Enable();
    }

    void OnDisable()
    {
        controls.Movement.Disable();
    }

}
