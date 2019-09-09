using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerRuby : MonoBehaviour //increases player health
{
    public float waitTime;
    public float gameTime;
    public float x_pos;
    public float y_pos;
    public AudioSource powerup;
    public ShipHealth player;
    public int healValue;

    private bool onScene;
    private bool appeared;

    void Start()
    {
        onScene = false;
        appeared = false;
        transform.position = new Vector2(20, 20);
        StartCoroutine(Wait(waitTime));
        if(onScene == true)
        {
            Appear();
        }
    }

    void Update()
    {
        if(onScene == true && appeared == false)
        {
            Appear();
        }
        if(onScene == false && appeared == true)
        {
            Destroy(gameObject, 0f);
        }
    }

    private IEnumerator Wait(float length)
    {
        WaitForSeconds delay1 = new WaitForSeconds(length);
        yield return delay1;
        if(GameData.diamond == true && appeared == false)
        {
            yield return new WaitForSeconds(GameData.diamondTime);
        }

        if (onScene == false)
        {
            onScene = true;
        }
        else
        {
            onScene = false;
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
            player.heal(healValue);
            gameObject.transform.position = new Vector2(20, 20);
            //Destroy(gameObject, 0f);
        }
    }
}
