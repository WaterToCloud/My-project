using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Name1 : MonoBehaviour
{
    public Text text;

    public void NameUno()
    {
        DataKeeping.playerName1 = name;
        name = text.text;
    }
}
