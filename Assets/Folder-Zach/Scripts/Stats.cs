using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public AudioSource metalMusic;

    public static int score;
    public int startScore = 0;
    public static float time;
    public float startTime = 30;

    public Text timeText;

    public GameObject gameOverButton;

	// Use this for initialization
	void Start ()
    {
        metalMusic.Play();
        score = startScore;
        time = startTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        time -= 1 * Time.deltaTime;

        time = Mathf.Clamp(time, 0f, Mathf.Infinity);

        timeText.text = string.Format("{0:00.00}", time);

        if (time <= 0)
        {
            time = 0;
            EndGame();
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            score += 1;
        }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            time -= 5;
        }
    }

    void EndGame()
    {
        metalMusic.Stop();
        //Time.timeScale = 0;
        gameOverButton.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
