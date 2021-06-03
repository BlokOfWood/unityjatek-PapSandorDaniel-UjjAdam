using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject originGameObject;
    public Weapon originWeapon;
    Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (originWeapon.Range < Vector2.Distance(startPos, transform.position))
        {
            Explode();
            return;
        }

        transform.position += transform.right * originWeapon.BulletSpeed * Time.deltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EntityComponent entityRef = collision.GetComponent<EntityComponent>();
        if(entityRef && collision.gameObject != originGameObject)
        {
            entityRef.CurrentHealth -= originWeapon.Damage;
            Explode();
        }
    }

    private void Explode()
    {
        GetComponent<Animator>().SetTrigger("Destroy");
        Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(this);
    }
}