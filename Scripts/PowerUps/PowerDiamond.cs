using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDiamond : MonoBehaviour //briefly stops all asteroid movement, resets asteroid speed to default
{
    public int waitTime;//time until powerup appears
    public int gameTime;//time powerup can be obtained (is visible)
    public int activeTime;//time powerup is active; must be different from gameTime
    public float x_pos;
    public float y_pos;
    public AudioSource powerup;

    private bool onScene;
    private bool appeared;
    private bool active;
    private bool expired;
    private AsteroidMovement[] asteroids;

    void Start()
    {
        GameData.diamond = false;
        GameData.diamondTime = 0;
        onScene = false;
        appeared = false;
        active = false;
        expired = false;
        transform.position = new Vector2(20, 20);

        StartCoroutine(Wait(waitTime));
        if(onScene == true)
        {
            Appear();
        }
    }

    void Update()
    {
        if(onScene == true && appeared == false && active == false)
        {
            Appear();
        }
        if(onScene == false && appeared == true && active == false)
        {
            Destroy(gameObject, 0f);
        }
        if(active == true && expired == true)//powerup ends
        {
            GameData.asteroidMotion = true;
            Destroy(gameObject, 0f);
        }
    }

    private IEnumerator Wait(int length)
    {
        WaitForSeconds delay1 = new WaitForSeconds(length);
        yield return delay1;

        if(onScene == false && active == false)
        {
            if(GameData.diamond == true && appeared == false)
            {
                yield return new WaitForSeconds(GameData.diamondTime);
            }
            onScene = true;
        }
        else if(onScene == true && active == false)
        {
            onScene = false;
        }
        else if(active == true && length == activeTime)
        {
            expired = true;
        }
    }

    private void Appear()
    {
        appeared = true;
        transform.position = new Vector2(x_pos, y_pos);
        StartCoroutine(Wait(gameTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.ToString().Contains("Missile"))
        {
            powerup.Play();
            GameData.asteroidMotion = false;
            GameData.diamond = true;
            GameData.diamondTime = activeTime;
            active = true;
            transform.position = new Vector2(20, 20);
            StartCoroutine(Wait(activeTime));
        }
    }
}
