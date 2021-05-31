using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    public Komplexfeladat InputActions;
    [Header("Regular Movement")]
    float lastMoveDirection = 0;
    public float MovementSpeed;
    [Header("Dash")]
    float DashCurrTime = 0;
    public float DashDuration;
    public float DashSpeed;
    [Header("Jump")]
    public float JumpSpeed;

    Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputActions = new Komplexfeladat();
        InputActions.Enable();
    }

    void Update()
    {
        /*Dash Trigger*/
        if (InputActions.PlayerMove.Dash.triggered)
            DashCurrTime = DashDuration;

        /*Jump*/
        if (InputActions.PlayerMove.Ugras.triggered && rb.velocity.y == 0)
        {
            rb.velocity += Vector2.up * JumpSpeed;
        }
    }

    void FixedUpdate()
    {
        /*Input*/
        float xInputAxis = InputActions.PlayerMove.Mozgo.ReadValue<float>();
        if (Mathf.Abs(xInputAxis) == 1)
            lastMoveDirection = xInputAxis;

        /*Movement*/
        if (DashCurrTime > 0)
        {
            rb.velocity = new Vector2(DashSpeed * lastMoveDirection, rb.velocity.y);
            DashCurrTime -= Time.fixedDeltaTime;
        }
        else
            rb.velocity = new Vector2(MovementSpeed * xInputAxis, rb.velocity.y);
    }
}
