using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EntityComponent))]
public class Playercontroller : MonoBehaviour
{
    [Header("References")]
    public Komplexfeladat InputActions;
    Rigidbody2D rb;

    [Header("Regular Movement")]
    float lastMoveDirection = 1;
    float MovementSpeed;
    float xInputAxis;

    [Header("Dash")]
    public float DashDuration;
    public float DashSpeed;
    float DashCurrTime = 0;

    [Header("Jump")]
    public float JumpVeloSens;
    public float JumpSpeed;

    [Header("Shooting")]
    public float BulletSpeed;
    public int CurrIndex;
    public Weapon[] Weapons;
    List<GameObject> currentBullets;

    [Header("Falling")]
    public float killLevel;
    public Vector3 SpawnOffset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputActions = new Komplexfeladat();
        InputActions.Enable();

        MovementSpeed = GetComponent<EntityComponent>().entity.MovementSpeed;

        currentBullets = new List<GameObject>();
    }

    void FixedUpdate()
    {

        /*Movement*/
        if (DashCurrTime > 0)
        {
            rb.velocity = new Vector2(DashSpeed * lastMoveDirection, rb.velocity.y);
            DashCurrTime -= Time.fixedDeltaTime;
        }
        else
            rb.velocity = new Vector2(MovementSpeed * xInputAxis, rb.velocity.y);

        if(transform.position.y < killLevel)
        {
            GetComponent<EntityComponent>().CurrentHealth--;
            try
            {
                GameObject otherPlayer = GameObject.FindGameObjectsWithTag("Player").First(x => x != gameObject);
                transform.position = otherPlayer.transform.position + SpawnOffset;
            }
            catch(Exception)
            {
                return;
            }
        }
    }

    public void Shoot(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) return;

        currentBullets.Add(Instantiate(Weapons[CurrIndex].Bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, lastMoveDirection * 90 - 90))));
        currentBullets[currentBullets.Count - 1].GetComponent<BulletScript>().originTag = tag;
        currentBullets[currentBullets.Count - 1].GetComponent<BulletScript>().originWeapon = Weapons[CurrIndex];
    }
    
    public void Jump(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) return;

        if (rb.velocity.y < JumpVeloSens)
        {
            rb.velocity += Vector2.up * JumpSpeed;
        }
    }

    public void Dash(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) return;

        if(DashCurrTime <= 0)
            DashCurrTime = DashDuration;
    }

    public void MovementInput(InputAction.CallbackContext ctx)
    {
        xInputAxis = ctx.ReadValue<float>();

        /*Saving Last Move Direction*/
        if (Mathf.Abs(xInputAxis) == 1)
            lastMoveDirection = xInputAxis;
    }

}
