using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton
    private static UIManager instance;
    public static UIManager Instance => instance ?? (instance = FindObjectOfType<UIManager>());
    #endregion

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject gameInPanel;
    [SerializeField] TextMeshProUGUI scoreText;

    public void ShowGameOverPanelHideGameInPanel()
    {
        Debug.Log(gameOverPanel);

        gameOverPanel.SetActive(true);

        gameInPanel.SetActive(false);
    }

    public void ShowGameInPanelHideGameOverPanel()
    {
        gameInPanel.SetActive(true);

        gameOverPanel.SetActive(false);
    }

    public void UpdateScoreText(int score)
    {
        scoreText.SetText(score.ToString());
    }
}
