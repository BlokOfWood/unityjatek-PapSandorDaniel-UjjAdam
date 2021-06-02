using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public byte Damage;
    public float Range;
    public GameObject Bullet;
    public Sprite BulletExp;
    public Sprite BulletLoop;
    public string Name;
}
