using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    WeaponConfig config;

    // Start is called before the first frame update
    void Start()
    {
        Shoot();
    }

    public void Shoot()
    {
        Debug.Log($"Did {config.damage} damage with {config.name}.");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
