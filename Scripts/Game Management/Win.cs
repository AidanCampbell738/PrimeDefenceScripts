using UnityEngine;

public class Win : MonoBehaviour
{
    public CanvasGroup message1;
    public CanvasGroup message2;
    public CanvasGroup message3;
    public CanvasGroup message4;

    void Start()
    {
        if(GameData.perfectScore == true)//gold on every level
        {
            GameData.goldMessage = true;
            message3.alpha = 1f;
            message4.alpha = 1f;
        }
        else//just level 16 beaten
        {
            message1.alpha = 1f;
            message2.alpha = 1f;
        }
    }

}
