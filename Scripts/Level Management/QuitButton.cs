using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
