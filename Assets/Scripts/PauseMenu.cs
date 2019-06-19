using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
public static bool GameIsPaused = false;

public GameObject pauseMenuUI;

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameIsPaused = !GameIsPaused;
            
            ChangeState(GameIsPaused);
        }
    }
public void ChangeState(bool b)
 {
    GameIsPaused = b;

    pauseMenuUI.SetActive(b);
    if(b)
        Time.timeScale = 0f;
    else
        Time.timeScale = 1f;
 }
 public void LoadMenu()
 {
Time.timeScale = 1f;
SceneManager.LoadScene("Menu");
 }
public void QuitGame()
{
    Application.Quit();
}
}
