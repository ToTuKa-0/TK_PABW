using UnityEngine;

public class Camera : MonoBehaviour
{
    // 中央＝0　右＝+　左＝-
    [SerializeField,Header("追従対象")] Transform player;
    [SerializeField, Header("X軸しきい値")] float x;
    [SerializeField, Header("Y軸しきい値")] float y;

    private float z = -10; // カメラのZ軸

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 cameraPos = transform.position;

        // X軸処理
        float right = cameraPos.x + x;

        if (player.position.x > right) // +処理
        {
            cameraPos.x = player.position.x - x;
        }
        else if (player.position.x < cameraPos.x - x) // -処理
        {
            cameraPos.x = player.position.x + x;
        }

        // Y軸処理
        float top = cameraPos.y + y;

        if (player.position.y > top) // +処理
        {
            cameraPos.y = player.position.y - y;
        }
        else if (player.position.y < cameraPos.y - y) // -処理
        {
            cameraPos.y = player.position.y + y;
        }

        // Z軸固定
        cameraPos.z = z;
        transform.position = cameraPos;
    }
}
