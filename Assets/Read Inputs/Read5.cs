using UnityEngine;
using UnityEngine.Windows;
using System.Collections;


public class Read5 : MonoBehaviour
{
    public string input5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string player5)
    {
        input5 = player5;
        Debug.Log(input5);

        DataKeeping.playerName5 = input5;
        Debug.Log(DataKeeping.playerName5);
    }
}
