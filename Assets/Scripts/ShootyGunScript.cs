using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed;
    private void Update()
    {
        HandleShooting();
    }

    private void HandleShooting()
    {
        if (Input.GetMouseButtonUp(0))
            Shoot();
    }

    private void Shoot()
    {
        var newBullet = Instantiate(bulletPrefab, spawnPoint.position, transform.rotation);
        var newBulletRigidBody = newBullet.GetComponent<Rigidbody2D>();
        
        newBullet.SetActive(true);
        var gunAngle = transform.rotation.z * Mathf.Deg2Rad;
        var velocityDir = new Vector2(Mathf.Sin(gunAngle), Mathf.Cos(gunAngle)).normalized;
        velocityDir = -newBullet.transform.right;
        newBulletRigidBody.velocity = velocityDir * bulletSpeed;
    }
}