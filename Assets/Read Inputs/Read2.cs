using UnityEngine;
using UnityEngine.Windows;
using System.Collections;


public class Read2 : MonoBehaviour
{
    private string input2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string player2)
    {
        input2 = player2;
        Debug.Log(input2);

        DataKeeping.playerName2 = input2;
        Debug.Log(DataKeeping.playerName2);
    }
}
