using UnityEngine;
using UnityEngine.Windows;
using System.Collections;


public class Read4 : MonoBehaviour
{
    private string input4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string player4)
    {
        input4 = player4;
        Debug.Log(input4);

        DataKeeping.playerName4 = input4;
        Debug.Log(DataKeeping.playerName4);
    }
}
