using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("SceneSolange");
        Time.timeScale = 1;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
