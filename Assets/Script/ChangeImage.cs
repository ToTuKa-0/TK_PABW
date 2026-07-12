using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField, Header("‰‚ß‚É•\¦‚³‚¹‚é‰æ‘œ")] Sprite sp1;
    [SerializeField, Header("•ÏX‚·‚é‰æ‘œ")] Sprite sp2;

    Image image;
    bool first = true;

    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = sp1;
    }

    public void Swap()
    {
        first = !first;
        image.sprite = first ? sp1 : sp2;
    }
}
