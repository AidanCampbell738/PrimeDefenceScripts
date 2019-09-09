using UnityEngine;
using UnityEngine.UI;

public class InstructionsButton : MonoBehaviour
{
    public MainMenu menu;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        GameData.instructionSlide = 1;
        menu.LoadInstructionsMenu();
    }
}
