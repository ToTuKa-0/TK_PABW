using System.IO.Hashing;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Vector2 pos1 = new Vector2(0, 0);
    [SerializeField] Vector2 pos2 = new Vector2(0, 0);
    [SerializeField] float moveSpeed = 0f;

    Vector2 target;

    void Start()
    {
        transform.position = pos1;
        target = pos2;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position, target, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pos1) ? pos2 : pos1;
        }
    }
}
