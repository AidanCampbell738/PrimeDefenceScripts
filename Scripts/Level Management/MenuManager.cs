using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup pauseLabel;
    public CanvasGroup loseLabel;
    public CanvasGroup winLabel;
    public CanvasGroup restartButton;
    public CanvasGroup quitButton;
    public CanvasGroup pauseButton;
    public CanvasGroup nextResumeButton;

    public ShipHealth player;
    public RectTransform restartPos;
    public RectTransform quitPos;

    void Start()
    {
        GameData.diamond = false;
        GameData.diamondTime = 0;
        GameData.levelClear = false;
        Time.timeScale = 1.0f;
        pauseButton.alpha = 1f;
        pauseButton.interactable = true;
        pauseLabel.alpha = 0f;//make all components disappear
        loseLabel.alpha = 0f;
        winLabel.alpha = 0f;
        restartButton.alpha = 0f;
        quitButton.alpha = 0f;
        nextResumeButton.alpha = 0f;
        pauseLabel.interactable = false;
        loseLabel.interactable = false;
        winLabel.interactable = false;
        restartButton.interactable = false;
        quitButton.interactable = false;
        nextResumeButton.interactable = false;
    }

    public void TogglePause()
    {
        if(pauseLabel.interactable == false)//set up pause menu
        {
            Time.timeScale = 0.0f;
            player.PauseMusic();

            restartPos.anchoredPosition = new Vector2(0f, -10f);
            quitPos.anchoredPosition = new Vector2(120f, -10f);

            GameObject.Find("ResumeButton2").GetComponentInChildren<Text>().text = "Resume";
            GameObject.Find("RestartButton").GetComponentInChildren<Text>().text = "Restart";

            pauseLabel.alpha = 1f;
            restartButton.alpha = 1f;
            quitButton.alpha = 1f;
            nextResumeButton.alpha = 1f;
            pauseLabel.interactable = true;
            restartButton.interactable = true;
            quitButton.interactable = true;
            nextResumeButton.interactable = true;

           
        }
        else//get rid of pause menu
        {
            player.UnpauseMusic();
            Time.timeScale = 1.0f;

            pauseLabel.alpha = 0f;
            restartButton.alpha = 0f;
            quitButton.alpha = 0f;
            nextResumeButton.alpha = 0f;
            pauseLabel.interactable = false;
            restartButton.interactable = false;
            quitButton.interactable = false;
            nextResumeButton.interactable = false;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
        restartPos.anchoredPosition = new Vector2(-60f, -10f);
        quitPos.anchoredPosition = new Vector2(60f, -10f);
        pauseButton.alpha = 0.0f;
        loseLabel.alpha = 1f;
        restartButton.alpha = 1f;
        quitButton.alpha = 1f;
        pauseButton.interactable = false;
        loseLabel.interactable = true;
        restartButton.interactable = true;
        quitButton.interactable = true;
    }

    public void LevelClear()
    {
        GameData.levelClear = true;
        Time.timeScale = 0.0f;
        restartPos.anchoredPosition = new Vector2(0f, -10f);
        quitPos.anchoredPosition = new Vector2(120f, -10f);
        pauseButton.alpha = 0.0f;
        pauseButton.interactable = false;

        GameObject.Find("ResumeButton2").GetComponentInChildren<Text>().text = "Next Level";
        GameObject.Find("RestartButton").GetComponentInChildren<Text>().text = "Replay";

        winLabel.alpha = 1f;
        winLabel.interactable = true;
        nextResumeButton.alpha = 1f;
        restartButton.alpha = 1f;
        quitButton.alpha = 1f;
        nextResumeButton.interactable = true;
        restartButton.interactable = true;
        quitButton.interactable = true;
    }
}
