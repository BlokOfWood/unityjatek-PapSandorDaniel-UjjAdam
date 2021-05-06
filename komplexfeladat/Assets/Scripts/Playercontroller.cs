using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    public Komplexfeladat InputActions;
    public float MovementSpeed;

    Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputActions = new Komplexfeladat();
        InputActions.Enable();
    }

    void FixedUpdate()
    {
        float xInputAxis = InputActions.PlayerMove.Mozgo.ReadValue<float>();

        rb.velocity = new Vector2(MovementSpeed * xInputAxis, rb.velocity.y);

        if (InputActions.PlayerMove.Ugras.phase==InputActionPhase.Started && rb.velocity.y==0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 10);
        }
        
    }
}
