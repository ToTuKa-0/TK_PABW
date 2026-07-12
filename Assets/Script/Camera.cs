using UnityEngine;

public class Camera : MonoBehaviour
{
    //中央＝0　右＝+　左＝-
    [SerializeField,Header("追従対象")] Transform player;
    [SerializeField, Header("X軸しきい値")] float x;
    [SerializeField, Header("Y軸しきい値")] float y;

    private float z = -10;

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 cameraPos = transform.position;

        float right = cameraPos.x + x;

        if (player.position.x > right)
        {
            cameraPos.x = player.position.x - x;
        }
        else if (player.position.x < cameraPos.x - x)
        {
            cameraPos.x = player.position.x + x;
        }

        float top = cameraPos.y + y;

        if (player.position.y > top)
        {
            cameraPos.y = player.position.y - y;
        }
        else if (player.position.y < cameraPos.y - y)
        {
            cameraPos.y = player.position.y + y;
        }

        cameraPos.z = z;
        transform.position = cameraPos;
    }
}
