using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeOut : MonoBehaviour
{
    [SerializeField, Tooltip("フェードアウトのimageをぶち込む")] Image fade;
    [SerializeField] string nextScene;
    [SerializeField, Tooltip("フェードアウトのスピード")] float outSpeed;

    bool fadeing = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !fadeing)
        {
            StartCoroutine(FadeOutLoad());
        }
    }

    IEnumerator FadeOutLoad()
    {
        fadeing = true;
        float t = 0;
        Color c = fade.color;

        while (t < outSpeed)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Clamp01(t / outSpeed);
            fade.color = new Color(c.r, c.g, c.b, alpha);

            yield return null;
        }

        SceneManager.LoadScene(nextScene);
    }
}
