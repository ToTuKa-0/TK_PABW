using UnityEngine;

public class ChcekOnObjject : MonoBehaviour
{
    [SerializeField, Tooltip("次に移行するキャンバスを入れる")] GameObject canvas;

    void Start()
    {
        canvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (canvas != null)
            {
                canvas.SetActive(false);
            }
            canvas.SetActive(false);
        }
    }
}
