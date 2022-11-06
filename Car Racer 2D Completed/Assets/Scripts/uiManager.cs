using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;

    public Text scoreText;

    bool gameOver;
    
    [SerializeField]bool gameRunning;

    int score;

    public AudioSource acceleration;

    private void Start()
    {
       

        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }


    void scoreUpdate()
    {
        scoreText.text = "Score: " + score;
        if (!gameOver)
        {
            score += 1;
        }
    }

    public void gameOverActive()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);

            AudioSource[] audios = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audio in audios)
            {
                acceleration.Pause();
            }
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlayScene");
    }

  public void Pause()
   {

        ChangeGameRunningState();
  
      //if (Time.timeScale == 1)
      //{
      //    Time.timeScale = 0f;  
      //}
      //else if (Time.timeScale == 0)
      //{
      //    Time.timeScale = 1f;
      //}
      
   }

    public void ChangeGameRunningState()
    {
        gameRunning = !gameRunning;

        if (gameRunning)//game running
        {
            Time.timeScale = 1f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audio in audios) 
            {
                acceleration.Play();
            }

        }
        else // game is Paused
        {
            //Time.timeScale = 0.25f;// slow motion play
            Time.timeScale = 0f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audio in audios)
            {
                acceleration.Pause();
            }
        }

    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }




}//class




