using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetDropdownValue : MonoBehaviour
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
                Debug.Log("No no no");
                break;
            case 1:
                Debug.Log("Yeet");
                DataKeeping.playerScore1 = DataKeeping.playerScore1 + 2;
                break;
            case 2:
                Debug.Log("Bleet");
                DataKeeping.playerScore2 = DataKeeping.playerScore2 + 2;
                break;
            case 3:
                Debug.Log("Jeet");
                DataKeeping.playerScore3 = DataKeeping.playerScore3 + 2;
                break;
            case 4:
                Debug.Log("Beet");
                DataKeeping.playerScore4 = DataKeeping.playerScore4 + 2;
                break;
            case 5:
                Debug.Log("Sleet");
                DataKeeping.playerScore5 = DataKeeping.playerScore5 + 2;
                break;
            case 6:
                Debug.Log("Skeet");
                DataKeeping.playerScore6 = DataKeeping.playerScore6 + 2;
                break;
        }
    }
}