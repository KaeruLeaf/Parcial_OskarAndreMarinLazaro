using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    Vector3 actualPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        actualPosition = transform.position;
        MoveLeft();
        MoveRight();

    }

    private void MoveLeft()
    {
        if (actualPosition.x > -8f)
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.transform.position += Vector3.left * speed * Time.deltaTime;
            }

        }
    }

    private void MoveRight() 
    {
        if (actualPosition.x < 8f)
        {

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.transform.position += Vector3.right * speed * Time.deltaTime;
            }

        }
    }

}
