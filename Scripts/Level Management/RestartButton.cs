using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Restart);
    }

    private void Restart()
    {
        switch(GameData.currentLevel)
        {
            case 1: SceneManager.LoadScene("Level1"); break;
            case 2: SceneManager.LoadScene("Level2"); break;
            case 3: SceneManager.LoadScene("Level3"); break;
            case 4: SceneManager.LoadScene("Level4"); break;
            case 5: SceneManager.LoadScene("Level5"); break;
            case 6: SceneManager.LoadScene("Level6"); break;
            case 7: SceneManager.LoadScene("Level7"); break;
            case 8: SceneManager.LoadScene("Level8"); break;
            case 9: SceneManager.LoadScene("Level9"); break;
            case 10: SceneManager.LoadScene("Level10"); break;
            case 11: SceneManager.LoadScene("Level11"); break;
            case 12: SceneManager.LoadScene("Level12"); break;
            case 13: SceneManager.LoadScene("Level13"); break;
            case 14: SceneManager.LoadScene("Level14"); break;
            case 15: SceneManager.LoadScene("Level15"); break;
            case 16: SceneManager.LoadScene("Level16"); break;
            default: break;
        }
        Time.timeScale = 1.0f;
    }
}
