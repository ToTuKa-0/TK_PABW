using UnityEngine;
using UnityEngine.UI;

public class ChangeManager : MonoBehaviour
{
    [SerializeField, Header("ïœçXÉLÅ[")] KeyCode changeKey = KeyCode.Space;

    ChangeImage[] changeImage;
    ChangeText[] changeText;

    void Start()
    {
        changeImage = FindObjectsByType<ChangeImage>(FindObjectsSortMode.None);
        changeText = FindObjectsByType<ChangeText>(FindObjectsSortMode.None);
    }

    void Update()
    {
        if (Input.GetKeyDown(changeKey))
        {
            foreach (ChangeImage image in changeImage)
                image.Swap();

            foreach (ChangeText text in changeText)
                text.Swap();
        }
    }
}
