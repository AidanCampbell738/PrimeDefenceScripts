using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public int levelNumber;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Event);
    }

    private void Event()
    {
        switch(levelNumber)
        {
            case 1: SceneManager.LoadScene("PreLevel1"); break;
            case 2: SceneManager.LoadScene("PreLevel2"); break;
            case 3: SceneManager.LoadScene("PreLevel3"); break;
            case 4: SceneManager.LoadScene("PreLevel4"); break;
            case 5: SceneManager.LoadScene("PreLevel5"); break;
            case 6: SceneManager.LoadScene("PreLevel6"); break;
            case 7: SceneManager.LoadScene("PreLevel7"); break;
            case 8: SceneManager.LoadScene("PreLevel8"); break;
            case 9: SceneManager.LoadScene("PreLevel9"); break;
            case 10: SceneManager.LoadScene("PreLevel10"); break;
            case 11: SceneManager.LoadScene("PreLevel11"); break;
            case 12: SceneManager.LoadScene("PreLevel12"); break;
            case 13: SceneManager.LoadScene("PreLevel13"); break;
            case 14: SceneManager.LoadScene("PreLevel14"); break;
            case 15: SceneManager.LoadScene("PreLevel15"); break;
            case 16: SceneManager.LoadScene("PreLevel16"); break;
            default: break;
        }
    }
}
