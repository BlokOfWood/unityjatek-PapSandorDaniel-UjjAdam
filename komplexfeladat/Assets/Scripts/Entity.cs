using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Entity")]
public class Entity : ScriptableObject
{
    public short Health;
    public float MovementSpeed;
}