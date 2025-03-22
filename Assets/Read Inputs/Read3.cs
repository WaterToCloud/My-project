using UnityEngine;
using UnityEngine.Windows;
using System.Collections;


public class Read3 : MonoBehaviour
{
    private string input3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string player3)
    {
        input3 = player3;
        Debug.Log(input3);

        DataKeeping.playerName3 = input3;
        Debug.Log(DataKeeping.playerName3);
    }
}
