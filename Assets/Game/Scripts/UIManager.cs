using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameManagement gameManager;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject gameInPanel;
    [SerializeField] TextMeshProUGUI scoreText;

    public void RestartLevel()
    {
        gameManager.RestartLevel();
    }

    public void ShowGameOverPanelHideGameInPanel()
    {
        gameOverPanel.SetActive(true);

        gameInPanel.SetActive(false);
    }

    public void ShowGameInPanelHideGameOverPanel()
    {
        gameInPanel.SetActive(true);

        gameOverPanel.SetActive(false);
    }
}
