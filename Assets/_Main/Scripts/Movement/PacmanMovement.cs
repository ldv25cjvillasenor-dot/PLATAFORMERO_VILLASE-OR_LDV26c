//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PacmanMovement : MonoBehaviour
//{
//    public float speedPacman = 5.0f;
//    bool Up;
//    bool Down;
//    bool Left;
//    bool Right;


//    Vector3 direccion = Vector3.zero;

//    void Update()

//    {
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            Up = true;
//            Down = false;
//            Left = false;
//            Right = false;

//            while (Up == true)
//            {
//                direccion = new Vector3(0, 1, 0) * speedPacman * Time.deltaTime;
//                transform.position += direccion;
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.S))
//        {
//            Down = true;
//            Up = false;
//            Left = false;
//            Right = false ;

//                while (Down == true)
//                {
//                    direccion = new Vector3(0, -1, 0) * speedPacman * Time.deltaTime;
//                    transform.position += direccion;
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.A))
//        {
//            Left = true;
//            Up = false;
//            Down = false;
//            Right = false;

//                while (Left == true)
//                {
//                    direccion = new Vector3(-1, 0, 0) * speedPacman * Time.deltaTime;
//                    transform.position += direccion;
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.D))
//        {
//            Right = true;
//            Up = false;
//            Down = false;
//            Left = false;

//                while (Right == true)
//                {
//                    direccion = new Vector3(1, 0, 0) * speedPacman * Time.deltaTime;
//                    transform.position += direccion;
//            }


//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    public float speedPacman = 5.0f;

    bool Up;
    bool Down;
    bool Left;
    bool Right;

    Vector3 direccion = Vector3.zero;
    

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Up = true;
            Down = false;
            Left = false;
            Right = false;

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Down = true;
            Up = false;
            Left = false;
            Right = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Left = true;
            Up = false;
            Down = false;
            Right = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Right = true;
            Up = false;
            Down = false;
            Left = false;
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

        transform.position += direccion * speedPacman * Time.deltaTime;
    }
}
