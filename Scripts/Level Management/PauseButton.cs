using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public MenuManager menu;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        menu.TogglePause();
    }
}
