using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetLow : MonoBehaviour
{
    public TMP_Dropdown Dropdown;

    void Start()
    {
        Dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
    }

    void DropdownValueChanged()
    {
        switch (Dropdown.value)
        {
            case 0:
                Debug.Log("No no no low");
                break;
            case 1:
                Debug.Log("Yeet low");
                DataKeeping.playerScore1 = DataKeeping.playerScore1 + 1;
                break;
            case 2:
                Debug.Log("Bleet low");
                DataKeeping.playerScore2 = DataKeeping.playerScore2 + 1;
                break;
            case 3:
                Debug.Log("Jeet low");
                DataKeeping.playerScore3 = DataKeeping.playerScore3 + 1;
                break;
            case 4:
                Debug.Log("Beet low");
                DataKeeping.playerScore4 = DataKeeping.playerScore4 + 1;
                break;
            case 5:
                Debug.Log("Sleet low");
                DataKeeping.playerScore5 = DataKeeping.playerScore5 + 1;
                break;
            case 6:
                Debug.Log("Skeet low");
                DataKeeping.playerScore6 = DataKeeping.playerScore6 + 1;
                break;
        }
    }
}