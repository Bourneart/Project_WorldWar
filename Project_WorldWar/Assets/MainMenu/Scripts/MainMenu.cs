using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    #region Нажатие кнопки Start Game
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

    #region Нажатие кнопки Settings
    public void SettingsMenu()
    {

    }
    #endregion

    #region Нажатие кнопки Exit
    public void ExitGame()
    {
        Application.Quit();
    }
    #endregion
}
