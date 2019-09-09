using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public float x_pos;
    public float y_pos;
    public int asteroidHealth;
    public ExplosionManager asteroidExplode;
    public AsteroidHealthBarManager healthBar;

    private int currentHealth;
    private AsteroidHealthBarManager barInstance;
    private float asteroidSpeed;

    void Start()
    {
        asteroidSpeed = 1f;
        currentHealth = asteroidHealth;
        barInstance = Instantiate(healthBar, new Vector3(x_pos, y_pos + 0.5f, 0), Quaternion.identity) as AsteroidHealthBarManager;
        barInstance.UpdateHealth(currentHealth);
    }

    void Update()
    {
        barInstance.UpdateSpeed(asteroidSpeed);
        barInstance.UpdateHealth(currentHealth);
    }

    public void takeDamage(int missileValue)
    {
        currentHealth /= missileValue;
        if(currentHealth <= 1)
        {
            Explosion();
        }
    }

    public int getHealth()
    {
        return(currentHealth);
    }

    public void UpdateSpeed(float value)
    {
        asteroidSpeed = value;
    }

    public void DestroyBar()
    {
        Destroy(barInstance.gameObject, 0f);
    }

    private void Explosion()
    {
        GameData.destroyedAsteroids++;
        AsteroidMovement motion = gameObject.GetComponentInParent(typeof(AsteroidMovement)) as AsteroidMovement;
        motion.ChangeSpeed(0f);
        ExplosionManager explosionInstance = Instantiate(asteroidExplode, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as ExplosionManager;
        Destroy(barInstance.gameObject, 0f);
        Destroy(gameObject, 0.0f);
    }
}
