using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour
{
    [SerializeField] CanvasGroup group;
    [SerializeField] float inSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FadeIN());
    }

    IEnumerator FadeIN()
    {
        float t = inSpeed;

        while (t > 0)
        {
            t -= Time.deltaTime;
            group.alpha = t / inSpeed;
            yield return null;
        }

        group.alpha = 0;
    }
}
