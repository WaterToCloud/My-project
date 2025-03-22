using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TextMeshProUGUI TimerTxt;

    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer(TimeLeft);

        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time is UP!");
            TimeLeft = 0;
            TimerOn = false;
            SceneManager.LoadScene("Voting");
        }


    }

    void updateTimer(float currentTime)
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
