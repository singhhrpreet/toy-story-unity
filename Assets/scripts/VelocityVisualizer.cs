using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityVisualizer : MonoBehaviour
{
    public float maxVelocity = 20f;

    void Update()
    {
        GetComponent<Renderer>().material.color = ColourVisualizer();      
    }

    private Color ColourVisualizer()
    {
        float velocity = GetComponent<Rigidbody>().velocity.magnitude;

        return Color.Lerp(Color.green, Color.red, velocity / maxVelocity);
    }
}
