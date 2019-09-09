using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public float x_pos;
    public float y_pos;
    public AudioSource crashSound;
    public float asteroidSpeed;
    public int asteroidDamage;
    public ShipHealth player;

    private Rigidbody2D asteroidRigid;
    private AsteroidHealth health;

    void Start()
    {
        GameData.asteroidMotion = true;
        asteroidRigid = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(x_pos, y_pos);
        health = GetComponent<AsteroidHealth>();
    }

    void Update()
    {
        if(GameData.asteroidMotion == true)
        {
            asteroidRigid.MovePosition(new Vector2(0, transform.position.y - asteroidSpeed * Time.deltaTime));
        }
        if(transform.position.y <= -3)
        {
            GameData.destroyedAsteroids++;
            health.DestroyBar();
            crashSound.Play();
            gameObject.transform.position = new Vector2(-15, 20);
            asteroidSpeed = 0;
            //Destroy(gameObject, 0f);
            if(player.GetShield())
            {
                player.DestroyShield();
            }
            else
            {
                player.takeDamage(asteroidDamage);
            }
        }
        health.UpdateSpeed(asteroidSpeed);
    }

    public void ChangeSpeed(float multiplier)
    {
        if(GameData.asteroidMotion == true)
        {
            asteroidSpeed *= multiplier;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.ToString().Contains("ShieldLaser"))
        {
            GameData.destroyedAsteroids++;
            health.DestroyBar();
            crashSound.Play();
            gameObject.transform.position = new Vector2(-15, 20);
            asteroidSpeed = 0;
            player.DestroyShield();
        }
    }
}
