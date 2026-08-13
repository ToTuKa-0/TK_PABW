using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField, Header("‰‚ß‚É•\¦‚³‚¹‚é‰æ‘œ")] Sprite sp1;
    [SerializeField, Header("•ÏX‚·‚é‰æ‘œ")] Sprite sp2;

    SpriteRenderer spriteRenderer;
    bool first = true;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sp1;
    }

    public void Swap()
    {
        first = !first;
        spriteRenderer.sprite = first ? sp1 : sp2;
    }
}


