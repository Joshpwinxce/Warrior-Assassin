 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;

   
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        levelMusic.Pause();
        Cursor.visible = true;
        gamePaused = true;
        Time.timeScale = 1;
    }


}
 