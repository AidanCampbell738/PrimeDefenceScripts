using UnityEngine;
using UnityEngine.UI;

public class ForwardButton : MonoBehaviour
{
    public MainMenu menu;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        if(GameData.instructionSlide >= 4)//On last slide
        {
            menu.LoadMainMenu();
        }
        else//go to next slide
        {
            GameData.instructionSlide++;
            menu.LoadInstructionsMenu();
        }
    }
}