using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void startGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void SetSenstivity(float sens)
    {
        PlayerPrefs.SetFloat("Sens", sens);
    }
}
