using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeBomb : MonoBehaviour
{
    [SerializeField]
    float explosionRange;
    [SerializeField]
    float timedBomb;
    [SerializeField]
    float explostionPower;

    void Start()
    {
        Invoke("Explode", timedBomb);
    }

    void Explode()
    {
        Collider[] hitObjects = Physics.OverlapSphere(transform.position, explosionRange);

        foreach (Collider hitItem in hitObjects)
        {
            hitItem.attachedRigidbody?.AddExplosionForce(explostionPower, transform.position, explosionRange, 3.0f);
        }
        Destroy(gameObject);

    }
}
