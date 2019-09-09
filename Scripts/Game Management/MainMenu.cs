using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public CanvasGroup galaxy;
    public CanvasGroup gameTitle;
    public CanvasGroup levelSelect;
    public CanvasGroup creditsLabel;
    public CanvasGroup instructionsLabel;
    public CanvasGroup missileLabel;
    public CanvasGroup powerupLabel;

    public CanvasGroup creditsBody;
    public CanvasGroup instructions1;
    public CanvasGroup instructions2;
    public CanvasGroup instructions3;
    public CanvasGroup instructions4;

    public CanvasGroup backButton;
    public CanvasGroup forwardButton;
    public CanvasGroup playButton;
    public CanvasGroup howButton;
    public CanvasGroup aboutButton;

    public CanvasGroup level1;
    public CanvasGroup level2;
    public CanvasGroup level3;
    public CanvasGroup level4;
    public CanvasGroup level5;
    public CanvasGroup level6;
    public CanvasGroup level7;
    public CanvasGroup level8;
    public CanvasGroup level9;
    public CanvasGroup level10;
    public CanvasGroup level11;
    public CanvasGroup level12;
    public CanvasGroup level13;
    public CanvasGroup level14;
    public CanvasGroup level15;
    public CanvasGroup level16;

    public Image medal1;
    public Image medal2;
    public Image medal3;
    public Image medal4;
    public Image medal5;
    public Image medal6;
    public Image medal7;
    public Image medal8;
    public Image medal9;
    public Image medal10;
    public Image medal11;
    public Image medal12;
    public Image medal13;
    public Image medal14;
    public Image medal15;
    public Image medal16;

    public Sprite goldMedal;
    public Sprite silverMedal;
    public Sprite check;

    public AudioSource menuMusic;

    void Start()
    {
        GameData.instructionSlide = 0;
        menuMusic.Play();
        LoadMainMenu();
    }

    public void LoadMainMenu()
    {
        GameData.instructionSlide = 0;
        galaxy.alpha = 1f;
        gameTitle.alpha = 1f;

        levelSelect.alpha = 0f;
        creditsLabel.alpha = 0f;
        creditsBody.alpha = 0f;

        instructionsLabel.alpha = 0f;
        missileLabel.alpha = 0f;
        powerupLabel.alpha = 0f;
        instructions1.alpha = 0f;
        instructions2.alpha = 0f;
        instructions3.alpha = 0f;
        instructions4.alpha = 0f;

        playButton.alpha = 1f;
        playButton.interactable = true;
        howButton.alpha = 1f;
        howButton.interactable = true;
        aboutButton.alpha = 1f;
        aboutButton.interactable = true;

        backButton.alpha = 0f;
        backButton.interactable = false;
        forwardButton.alpha = 0f;
        forwardButton.interactable = false;

        level1.alpha = 0f;
        level1.interactable = false;
        level2.alpha = 0f;
        level2.interactable = false;
        level3.alpha = 0f;
        level3.interactable = false;
        level4.alpha = 0f;
        level4.interactable = false;
        level5.alpha = 0f;
        level5.interactable = false;
        level6.alpha = 0f;
        level6.interactable = false;
        level7.alpha = 0f;
        level7.interactable = false;
        level8.alpha = 0f;
        level8.interactable = false;
        level9.alpha = 0f;
        level9.interactable = false;
        level10.alpha = 0f;
        level10.interactable = false;
        level11.alpha = 0f;
        level11.interactable = false;
        level12.alpha = 0f;
        level12.interactable = false;
        level13.alpha = 0f;
        level13.interactable = false;
        level14.alpha = 0f;
        level14.interactable = false;
        level15.alpha = 0f;
        level15.interactable = false;
        level16.alpha = 0f;
        level16.interactable = false;

        medal1.GetComponent<CanvasGroup>().alpha = 0f;
        medal2.GetComponent<CanvasGroup>().alpha = 0f;
        medal3.GetComponent<CanvasGroup>().alpha = 0f;
        medal4.GetComponent<CanvasGroup>().alpha = 0f;
        medal5.GetComponent<CanvasGroup>().alpha = 0f;
        medal6.GetComponent<CanvasGroup>().alpha = 0f;
        medal7.GetComponent<CanvasGroup>().alpha = 0f;
        medal8.GetComponent<CanvasGroup>().alpha = 0f;
        medal9.GetComponent<CanvasGroup>().alpha = 0f;
        medal10.GetComponent<CanvasGroup>().alpha = 0f;
        medal11.GetComponent<CanvasGroup>().alpha = 0f;
        medal12.GetComponent<CanvasGroup>().alpha = 0f;
        medal13.GetComponent<CanvasGroup>().alpha = 0f;
        medal14.GetComponent<CanvasGroup>().alpha = 0f;
        medal15.GetComponent<CanvasGroup>().alpha = 0f;
        medal16.GetComponent<CanvasGroup>().alpha = 0f;

    }

    public void LoadLevelMenu()
    {
        galaxy.alpha = 0f;
        gameTitle.alpha = 0f;
        levelSelect.alpha = 1f;

        playButton.alpha = 0f;
        playButton.interactable = false;
        howButton.alpha = 0f;
        howButton.interactable = false;
        aboutButton.alpha = 0f;
        aboutButton.interactable = false;

        backButton.alpha = 1f;
        backButton.interactable = true;

        level1.alpha = 1f;
        level1.interactable = true;
        level2.alpha = 1f;
        level2.interactable = true;
        level3.alpha = 1f;
        level3.interactable = true;
        level4.alpha = 1f;
        level4.interactable = true;
        level5.alpha = 1f;
        level5.interactable = true;
        level6.alpha = 1f;
        level6.interactable = true;
        level7.alpha = 1f;
        level7.interactable = true;
        level8.alpha = 1f;
        level8.interactable = true;
        level9.alpha = 1f;
        level9.interactable = true;
        level10.alpha = 1f;
        level10.interactable = true;
        level11.alpha = 1f;
        level11.interactable = true;
        level12.alpha = 1f;
        level12.interactable = true;
        level13.alpha = 1f;
        level13.interactable = true;
        level14.alpha = 1f;
        level14.interactable = true;
        level15.alpha = 1f;
        level15.interactable = true;
        level16.alpha = 1f;
        level16.interactable = true;

        medal1.GetComponent<CanvasGroup>().alpha = 1f;
        medal2.GetComponent<CanvasGroup>().alpha = 1f;
        medal3.GetComponent<CanvasGroup>().alpha = 1f;
        medal4.GetComponent<CanvasGroup>().alpha = 1f;
        medal5.GetComponent<CanvasGroup>().alpha = 1f;
        medal6.GetComponent<CanvasGroup>().alpha = 1f;
        medal7.GetComponent<CanvasGroup>().alpha = 1f;
        medal8.GetComponent<CanvasGroup>().alpha = 1f;
        medal9.GetComponent<CanvasGroup>().alpha = 1f;
        medal10.GetComponent<CanvasGroup>().alpha = 1f;
        medal11.GetComponent<CanvasGroup>().alpha = 1f;
        medal12.GetComponent<CanvasGroup>().alpha = 1f;
        medal13.GetComponent<CanvasGroup>().alpha = 1f;
        medal14.GetComponent<CanvasGroup>().alpha = 1f;
        medal15.GetComponent<CanvasGroup>().alpha = 1f;
        medal16.GetComponent<CanvasGroup>().alpha = 1f;

        switch (GameData.levelTracker[0])
        {
            case int n when (n >= 1 && n <= 10): medal1.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal1.sprite = silverMedal; break;
            case 15: medal1.sprite = goldMedal; break;
            default: medal1.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[1])
        {
            case int n when (n >= 1 && n <= 10): medal2.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal2.sprite = silverMedal; break;
            case 15: medal2.sprite = goldMedal; break;
            default: medal2.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[2])
        {
            case int n when (n >= 1 && n <= 10): medal3.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal3.sprite = silverMedal; break;
            case 15: medal3.sprite = goldMedal; break;
            default: medal3.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[3])
        {
            case int n when (n >= 1 && n <= 10): medal4.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal4.sprite = silverMedal; break;
            case 15: medal4.sprite = goldMedal; break;
            default: medal4.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[4])
        {
            case int n when (n >= 1 && n <= 10): medal5.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal5.sprite = silverMedal; break;
            case 15: medal5.sprite = goldMedal; break;
            default: medal5.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[5])
        {
            case int n when (n >= 1 && n <= 10): medal6.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal6.sprite = silverMedal; break;
            case 15: medal6.sprite = goldMedal; break;
            default: medal6.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[6])
        {
            case int n when (n >= 1 && n <= 10): medal7.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal7.sprite = silverMedal; break;
            case 15: medal7.sprite = goldMedal; break;
            default: medal7.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[7])
        {
            case int n when (n >= 1 && n <= 10): medal8.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal8.sprite = silverMedal; break;
            case 15: medal8.sprite = goldMedal; break;
            default: medal8.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[8])
        {
            case int n when (n >= 1 && n <= 10): medal9.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal9.sprite = silverMedal; break;
            case 15: medal9.sprite = goldMedal; break;
            default: medal9.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[9])
        {
            case int n when (n >= 1 && n <= 10): medal10.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal10.sprite = silverMedal; break;
            case 15: medal10.sprite = goldMedal; break;
            default: medal10.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[10])
        {
            case int n when (n >= 1 && n <= 10): medal11.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal11.sprite = silverMedal; break;
            case 15: medal11.sprite = goldMedal; break;
            default: medal11.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[11])
        {
            case int n when (n >= 1 && n <= 10): medal12.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal12.sprite = silverMedal; break;
            case 15: medal12.sprite = goldMedal; break;
            default: medal12.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[12])
        {
            case int n when (n >= 1 && n <= 10): medal13.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal13.sprite = silverMedal; break;
            case 15: medal13.sprite = goldMedal; break;
            default: medal13.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[13])
        {
            case int n when (n >= 1 && n <= 10): medal14.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal14.sprite = silverMedal; break;
            case 15: medal14.sprite = goldMedal; break;
            default: medal14.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[14])
        {
            case int n when (n >= 1 && n <= 10): medal15.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal15.sprite = silverMedal; break;
            case 15: medal15.sprite = goldMedal; break;
            default: medal15.GetComponent<CanvasGroup>().alpha = 0f; break;
        }

        switch (GameData.levelTracker[15])
        {
            case int n when (n >= 1 && n <= 10): medal16.sprite = check; break;
            case int n when (n >= 11 && n <= 14): medal16.sprite = silverMedal; break;
            case 15: medal16.sprite = goldMedal; break;
            default: medal16.GetComponent<CanvasGroup>().alpha = 0f; GameData.goldMessage = false; break;
        }
    }

    public void LoadCreditsMenu()
    {
        galaxy.alpha = 1f;
        gameTitle.alpha = 0f;

        playButton.alpha = 0f;
        playButton.interactable = false;
        howButton.alpha = 0f;
        howButton.interactable = false;
        aboutButton.alpha = 0f;
        aboutButton.interactable = false;

        backButton.alpha = 1f;
        backButton.interactable = true;
        creditsLabel.alpha = 1f;
        creditsBody.alpha = 1f;
    }

    public void LoadInstructionsMenu()
    {
        galaxy.alpha = 0f;
        gameTitle.alpha = 0f;
        playButton.alpha = 0f;
        playButton.interactable = false;
        howButton.alpha = 0f;
        howButton.interactable = false;
        aboutButton.alpha = 0f;
        aboutButton.interactable = false;
        backButton.alpha = 1f;
        backButton.interactable = true;

        backButton.alpha = 1f;
        backButton.interactable = true;
        forwardButton.alpha = 1f;
        forwardButton.interactable = true;

        instructionsLabel.alpha = 0f;
        missileLabel.alpha = 0f;
        powerupLabel.alpha = 0f;
        instructions1.alpha = 0f;
        instructions2.alpha = 0f;
        instructions3.alpha = 0f;
        instructions4.alpha = 0f;

        if(GameData.instructionSlide == 1)
        {
            instructionsLabel.alpha = 1f;
            instructions1.alpha = 1f;
        }
        else if(GameData.instructionSlide == 2)
        {
            instructionsLabel.alpha = 1f;
            instructions2.alpha = 1f;
        }
        else if(GameData.instructionSlide == 3)
        {
            missileLabel.alpha = 1f;
            instructions3.alpha = 1f;
        }
        else if(GameData.instructionSlide == 4)
        {
            powerupLabel.alpha = 1f;
            instructions4.alpha = 1f;
        }
        else
        {
            LoadMainMenu();
        }

    }
}
