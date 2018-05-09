using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public AudioSource metalMusic;
    //public AudioSource newTimeAudio;

    public Animator textFlash;

    public static int score;
    public int startScore = 0;
    public static float time;
    public float countdown;

    public Text timeText;
    public Text countdownText;

    public GameObject gameOverButton, toggleOption;

    // Use this for initialization
    void Start()
    {
        time = Random.Range(30, 60);
        countdown = 30;
        StartCoroutine(ChangeTime());

        textFlash.StartPlayback();

        metalMusic.Play();
        score = startScore;
    }

    IEnumerator ChangeTime()
    {
        while (true)
        {
            //newTimeAudio.Play();

            yield return new WaitForSeconds(30);

            float newTime = Random.Range(5, 10);

            time = newTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        countdown -= 1 * Time.deltaTime;

        time = Mathf.Clamp(time, 0f, Mathf.Infinity);
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        timeText.text = string.Format("{0:00.0}", time);
        countdownText.text = string.Format("{0:00.00}", countdown);

        if (time <= 0)
        {
            time = 0;
            EndGame();
        }

        if (countdown <= 0)
        {
            countdown = 30;
            textFlash.StartPlayback();
        }

        if (countdown <= 10 && countdown > 0)
        {
            textFlash.StopPlayback();
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
        StopAllCoroutines();
        gameOverButton.SetActive(true);
    }

    public void BackToMenu()
    {
        Destroy(ServiceLocator.instance.toggleOptions);
        SceneManager.LoadScene("MainMenu");
    }
}
