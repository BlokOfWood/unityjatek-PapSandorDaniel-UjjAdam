using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public byte Damage;
    public float BulletSpeed;
    public float Range;
    public GameObject Bullet;
    public GameObject BulletSpawn;
    public GameObject BulletDestroy;
    public string Name;
}
