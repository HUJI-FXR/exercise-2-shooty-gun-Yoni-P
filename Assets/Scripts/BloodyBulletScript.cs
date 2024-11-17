using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodyBulletScript : MonoBehaviour
{
    [SerializeField] private GameObject bloodEffectPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            Instantiate(bloodEffectPrefab, other.GetContact(0).point, bloodEffectPrefab.transform.rotation);
        }
        Destroy(gameObject);
    }
}
