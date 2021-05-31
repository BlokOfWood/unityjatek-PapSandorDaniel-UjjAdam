using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityComponent : MonoBehaviour
{
    public Entity entity;
    public float CurrentHealth;

    private void Awake()
    {
        CurrentHealth = entity.Health;
    }
}
