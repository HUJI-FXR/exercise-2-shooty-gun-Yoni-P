using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    private void Update()
    {
        AimGun();
    }

    private void AimGun()
    {
        
        var relativeVec = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        float rot = Vector2.SignedAngle(Vector2.left, relativeVec);
        
        transform.localRotation = Quaternion.Euler(0, 0 ,rot);
    }
}
