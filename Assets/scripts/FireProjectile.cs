using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform origin;

    public void shoot()
    {
        Instantiate(projectile, origin.transform.position, origin.transform.rotation);
    }
}
