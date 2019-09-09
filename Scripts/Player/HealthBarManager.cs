using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public Sprite HealthBar0;
    public Sprite HealthBar1;
    public Sprite HealthBar2;
    public Sprite HealthBar3;
    public Sprite HealthBar4;
    public Sprite HealthBar5;
    public Sprite HealthBar6;
    public Sprite HealthBar7;
    public Sprite HealthBar8;
    public Sprite HealthBar9;
    public Sprite HealthBar10;
    public Sprite HealthBar11;
    public Sprite HealthBar12;
    public Sprite HealthBar13;
    public Sprite HealthBar14;
    public Sprite HealthBar15;
    public ShipHealth player;

    private int curHealth;
    private Sprite[] HealthBars = new Sprite[16];

    void Start()
    {
        HealthBars[0] = HealthBar0;
        HealthBars[1] = HealthBar1;
        HealthBars[2] = HealthBar2;
        HealthBars[3] = HealthBar3;
        HealthBars[4] = HealthBar4;
        HealthBars[5] = HealthBar5;
        HealthBars[6] = HealthBar6;
        HealthBars[7] = HealthBar7;
        HealthBars[8] = HealthBar8;
        HealthBars[9] = HealthBar9;
        HealthBars[10] = HealthBar10;
        HealthBars[11] = HealthBar11;
        HealthBars[12] = HealthBar12;
        HealthBars[13] = HealthBar13;
        HealthBars[14] = HealthBar14;
        HealthBars[15] = HealthBar15;

        curHealth = player.getHealth();
        gameObject.GetComponent<Image>().sprite = HealthBars[curHealth];

    }

    void Update()
    {
        curHealth = player.getHealth();
        if(curHealth <= 0)
        {
            gameObject.GetComponent<Image>().sprite = HealthBars[0];
        }
        else if(curHealth >= 15)
        {
            gameObject.GetComponent<Image>().sprite = HealthBars[15];
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = HealthBars[curHealth];
        }
    }
}
