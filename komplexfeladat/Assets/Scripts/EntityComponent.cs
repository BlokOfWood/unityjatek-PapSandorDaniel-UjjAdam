using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityComponent : MonoBehaviour
{
    public Entity entity;
    public float CurrentHealth;
    public GameObject puftofsmoke;

    private void Awake()
    {
        CurrentHealth = entity.Health;
    }

    private void FixedUpdate()
    {
        if(CurrentHealth <= 0)
        {
            Instantiate(puftofsmoke, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.02f);
        }
    }
}
