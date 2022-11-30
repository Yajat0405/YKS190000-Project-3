using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 12f;
    public float gravity;
    Vector3 velocity;
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public float jumpHeight = 2f;
    public LayerMask groundMask;
    bool isGrounded;
    private void Update()
    {
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed *Time.deltaTime);
    }

    IEnumerator LockTimer()
    {
        speed = 0f;
        yield return new WaitForSeconds(5);
        speed = 0f;
        ResumeMovement();
    }
    public void LockMovement()
    {
        speed = 0f;
        Debug.Log("speed 0");
        StartCoroutine(LockTimer());
    }

    public void ResumeMovement()
    {
        speed = 12f;
    }

    public void HalfSpeed()
    {
        speed = 6f;
    }
}
