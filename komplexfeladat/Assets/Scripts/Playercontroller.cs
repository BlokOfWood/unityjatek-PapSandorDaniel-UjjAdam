using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    [Header("References")]
    public Komplexfeladat InputActions;

    [Header("Regular Movement")]
    public float MovementSpeed;
    float lastMoveDirection = 0;

    [Header("Dash")]
    public float DashDuration;
    public float DashSpeed;
    float DashCurrTime = 0;

    [Header("Jump")]
    public float JumpVeloSens;
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
        if (InputActions.PlayerMove.Ugras.triggered && rb.velocity.y < JumpVeloSens)
        {
            rb.velocity += Vector2.up * JumpSpeed;
        }
    }

    void FixedUpdate()
    {
        /*Regular Movement Input*/
        float xInputAxis = InputActions.PlayerMove.Mozgo.ReadValue<float>();

        /*Saving Last Move Direction*/
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
