using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    [SerializeField] UIManager uIManager;


    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        uIManager.ShowGameOverPanelHideGameInPanel();

        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
