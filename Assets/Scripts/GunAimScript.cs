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
        
        var relativePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        relativePos.z = 0;

        float rot = Vector3.SignedAngle(Vector3.left, relativePos, Vector3.forward);
        transform.localRotation = Quaternion.Euler(0, 0 ,rot);
    }
}
