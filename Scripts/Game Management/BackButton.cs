using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public MainMenu menu;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        if(GameData.instructionSlide <= 1)//not in instructions menu or on 1st slide
        {
            menu.LoadMainMenu();
        }
        else//go back to previous slide
        {
            GameData.instructionSlide--;
            menu.LoadInstructionsMenu();
        }
    }
}
