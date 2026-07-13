using UnityEngine;

public class RespawnSystem : MonoBehaviour
{
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            transform.position = startPos;
        }
    }
}
