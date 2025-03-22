using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Read : MonoBehaviour
{
    public static string input;

    public void ReadStringInput(string player1)
    {
        input = player1;
        Debug.Log(input);

        DataKeeping.playerName1 = input;
        Debug.Log(DataKeeping.playerName1);
    }
}
