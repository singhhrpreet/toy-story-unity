using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BatFollower : MonoBehaviour
{
    private BatMarker batMan;
    private Rigidbody rb;
    private Vector3 travelSpeed;

    public float sensitivity = 100f;

    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 destination = batMan.transform.position;
        rb.transform.rotation = transform.rotation;

        travelSpeed = (destination - rb.transform.position) * sensitivity;

        rb.velocity = travelSpeed;
    }

    private void Update()
    {
        transform.rotation = batMan.transform.rotation;

    }

    public void SetFollowTarget(BatMarker isTarget)
    {
        batMan = isTarget;
    }
}
