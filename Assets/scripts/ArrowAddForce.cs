using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class ArrowAddForce : MonoBehaviour
{
    Rigidbody rb;

    public float force = 100f, timer = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);

        Destroy(gameObject, timer);
    }
}
