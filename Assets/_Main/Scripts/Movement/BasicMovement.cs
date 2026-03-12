using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speedMovement = 5.0f;

    bool Up;
    bool Down;
    bool Left;
    bool Right;

    Vector3 direccion = Vector3.zero;

    void Update()
    {
        // Resetear todo cada frame
        Up = false;
        Down = false;
        Left = false;
        Right = false;

        direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            Up = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Down = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Left = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Right = true;
        }

        if (Up)
        {
            direccion = new Vector3(0, 1, 0);
        }
        else if (Down)
        {
            direccion = new Vector3(0, -1, 0);
        }
        else if (Left)
        {
            direccion = new Vector3(-1, 0, 0);
        }
        else if (Right)
        {
            direccion = new Vector3(1, 0, 0);
        }

        transform.position += direccion * speedMovement * Time.deltaTime;
    }
}
