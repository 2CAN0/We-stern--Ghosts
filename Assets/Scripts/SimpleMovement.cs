using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 velocity = new Vector3(1, 1, 1);
    private Vector3 actualVelocity = Vector3.zero;
    public float amplitude = 5;
    private int hopCounter = 0;
    public float jumpForce = 12f;
    public bool sprint = true;
    public bool hop = true;

    private void Start()
    {
        
    }

    void Update()
    {
        actualVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            actualVelocity.z = velocity.z * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            actualVelocity.z = -velocity.z * Time.deltaTime;
        }
        else
        {
            actualVelocity.z = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            actualVelocity.x = velocity.x * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            actualVelocity.x = -velocity.x * Time.deltaTime;
        }
        else
        {
            actualVelocity.x = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            actualVelocity.y += jumpForce;
        }

        if (hop)
        {
            if (hopCounter % amplitude == 0 && hopCounter != 0)
                velocity.y *= -1;

            if (actualVelocity.magnitude != 0)
            {
                actualVelocity.y += velocity.y;
                hopCounter++;
            }
        }

        if (sprint && Input.GetKey(KeyCode.LeftShift)){
            actualVelocity.z *= 2;
            actualVelocity.x *= 2;
        }

        transform.Translate(actualVelocity);
    }
}
