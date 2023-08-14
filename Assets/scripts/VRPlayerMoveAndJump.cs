using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VRPlayerMoveAndJump : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistiance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public bool isGrounded;

    public GameObject cam;

    public bool isFreeMove;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistiance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isFreeMove)
        {
            Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            Vector3 move = cam.transform.TransformDirection(input.x, 0, input.y);
            move = move.magnitude == 0 ? Vector3.zero : move / move.magnitude;

            controller.Move(new Vector3(move.x, 0, move.z) * speed * Time.deltaTime);
        }


        if (OVRInput.Get(OVRInput.Button.One) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
