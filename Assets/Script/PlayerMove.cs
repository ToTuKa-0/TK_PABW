using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] float jumpPower = 0;

    private Rigidbody2D rb;
    private bool floor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

            floor = false;
        }
    }

    void FixedUpdate()
    {
        // 移動
        float x = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);
    }

    // boolの切り替え(地面についていない)
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            floor = true;
        }
    }

    // boolの切り替え(地面についた)
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            floor = false;
        }
    }
}
