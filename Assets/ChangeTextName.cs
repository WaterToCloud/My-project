using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextName : MonoBehaviour
{

    public Text text;
    private string testText = Saving.value.ToString();

    private void Start()
    {
        text.text = testText;
    }
}
