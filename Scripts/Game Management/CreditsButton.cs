using UnityEngine;
using UnityEngine.UI;

public class CreditsButton : MonoBehaviour
{
    public MainMenu menu;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        menu.LoadCreditsMenu();
    }
}
