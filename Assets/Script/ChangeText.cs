using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField, Header("初めに表示させる色")] Color color1 = Color.black;
    [SerializeField, Header("変更する色")] Color color2 = Color.white;

    TMP_Text text;
    bool first = true;

    void Start()
    {
        text = GetComponent<TMP_Text>();
        text.color = color1;
    }

    public void Swap()
    {
        first = !first;
        text.color = first ? color1 : color2;
    }
}
