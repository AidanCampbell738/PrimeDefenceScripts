using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipHealth : MonoBehaviour
{
    public int startHealth;
    public AudioSource battleTheme;
    public ExplosionManager shipExplosion;
    public MenuManager menu;
    public SpriteRenderer shieldLine;
    public int numAsteroids;

    private int currentHealth;
    private bool shield;
    private SpriteRenderer shieldInstance;
    private int flag;

    void Start()
    {
        GameData.destroyedAsteroids = 0;
        shield = false;
        currentHealth = startHealth;
        battleTheme.Play();
    }

    void Update()
    {
        if(GameData.destroyedAsteroids == numAsteroids && currentHealth > 0)
        {
            gameObject.GetComponent<ShipShooting>().Death();
            battleTheme.Stop();
            transform.position = new Vector2(-20, 20);
            flag = 1;
            if(currentHealth > GameData.levelTracker[GameData.currentLevel - 1])
            {
                GameData.levelTracker[GameData.currentLevel - 1] = currentHealth;
            }
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.6f);
        if(flag == 0)
        {
            menu.GameOver();
        }
        else
        {
            GameData.perfectScore = true;
            for(int i = 0; i < 16; i++)
            {
                if(GameData.levelTracker[i] != 15)
                {
                    GameData.perfectScore = false;
                    i = 20;
                }
            }

            //will display win menu if level 16 is beaten
            //will also display win menu once 16 gold medals have been achieved (only once)
            //beating level 16 will display the gold menu if 16 golds have been achieved
            if(GameData.currentLevel == 16 || (GameData.goldMessage == false && GameData.perfectScore == true))
            {
                SceneManager.LoadScene("WinMenu");
            }
            else
            {
                menu.LevelClear();
            }
        }
    }

    public void heal(int amount)
    {
        currentHealth += amount;
        if(currentHealth >= 15)
        {
            currentHealth = 15;
        }
    }

    public void takeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            gameObject.GetComponent<ShipShooting>().Death();
            battleTheme.Stop();
            ExplosionManager explosionInstance = Instantiate(shipExplosion, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as ExplosionManager;
            transform.position = new Vector2(-20, 20);
            flag = 0;
            StartCoroutine(Wait());
        }
    }

    public int getHealth()
    {
        return(currentHealth);
    }

    public void EquipShield()
    {
        shield = true;
        shieldInstance = Instantiate(shieldLine) as SpriteRenderer;
    }

    public void DestroyShield()
    {
        shield = false;
        Destroy(shieldInstance.gameObject, 0f);
    }

    public bool GetShield()
    {
        return shield;
    }

    public void PauseMusic()
    {
        battleTheme.Pause();
    }

    public void UnpauseMusic()
    {
        battleTheme.UnPause();
    }
}
