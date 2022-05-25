using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unnamed Weapon", menuName = "Weapon Config", order = 0)]
public class WeaponConfig : ScriptableObject 
{
    public float maxAmmo;
    public float damage;
    public bool areaDamage;
}