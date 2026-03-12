using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRigidBody : MonoBehaviour
{
    public bool Jumping = false;
    public float JumpForce = 10f;
    public Vector3 JumpDirection = new Vector3(0, 1, 0);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Jumping == false)
        {
            Jumping = true;
            GetComponent<Rigidbody2D>().AddForce(JumpDirection * JumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jumping = false;
    }
}
