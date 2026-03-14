using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speedMovement = 5f;
    public float jumpForce = 8f;

    Rigidbody2D rb;
    Animator anim;

    float moveX;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        float yDirection = 0;

        if (rb.velocity.y > 0.1f)
            yDirection = 1;
        else if (rb.velocity.y < -0.1f)
            yDirection = -1;

        anim.SetFloat("Xpoint", moveX);
        anim.SetFloat("Ypoint", yDirection);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * speedMovement, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
