using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;


public class NextRound : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        Saving.value = Saving.value + 1;

        if (Saving.value > 2)

            {
            SceneManager.LoadScene("Rules");
            Debug.Log(Saving.value);
        }
            else
            {
            SceneManager.LoadScene(sceneName);
            Debug.Log(Saving.value);

        }
    } 
}
