using UnityEngine;
using UnityEngine.Windows;
using System.Collections;


public class Read6 : MonoBehaviour
{
    private string input6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string player6)
    {
        input6 = player6;
        Debug.Log(input6);

        DataKeeping.playerName6 = input6;
        Debug.Log(DataKeeping.playerName6);
    }
}
