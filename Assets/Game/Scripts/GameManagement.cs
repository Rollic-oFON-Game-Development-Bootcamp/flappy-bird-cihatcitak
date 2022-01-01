using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    #region Singleton
    private static GameManagement instance;
    public static GameManagement Instance => instance ?? (instance = FindObjectOfType<GameManagement>());
    #endregion

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        UIManager.Instance.ShowGameOverPanelHideGameInPanel();

        Time.timeScale = 0f;
    }

    public void ReStartLevel()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
