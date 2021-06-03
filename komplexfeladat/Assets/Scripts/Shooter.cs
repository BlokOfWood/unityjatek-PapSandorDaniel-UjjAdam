using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float ShooterCooldown;
    List<GameObject> currentBullets;
    public Weapon weapon;

    void Start()
    {
        currentBullets = new List<GameObject>();
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            currentBullets.Add(Instantiate(weapon.Bullet, transform.position, Quaternion.Euler(new Vector3(0, 180, 0))));
            currentBullets[currentBullets.Count - 1].GetComponent<BulletScript>().originTag = tag;
            currentBullets[currentBullets.Count - 1].GetComponent<BulletScript>().originWeapon = weapon;
            yield return new WaitForSeconds(ShooterCooldown);
        }
    }
}
