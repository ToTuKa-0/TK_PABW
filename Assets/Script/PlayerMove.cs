using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] float jumpPower = 0;

    Rigidbody2D rb;
    SpriteRenderer sr;
    bool floor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

            floor = false;
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        if (x > 0)
        {
            sr.flipX = false;
        }
        else if (x < 0)
        {
            sr.flipX = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            floor = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            floor = false;
        }
    }
}
