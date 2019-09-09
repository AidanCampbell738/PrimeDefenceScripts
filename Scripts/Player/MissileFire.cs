using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFire : MonoBehaviour
{

    public int numberValue;
    public float missileSpeed;
    public float lifespan;
    public AudioSource fireSound;
    public float speedMultiplier;

    private Rigidbody2D m_Rigidbody;

    private void Start()
    {
        fireSound.Play();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifespan);
    }

    void Update()
    {
        m_Rigidbody.MovePosition(new Vector2(0, transform.position.y + missileSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.ToString().Contains("Asteroid"))
        {
            gameObject.transform.position = new Vector2(15, 20);
            Destroy(gameObject, 0.5f);
            AsteroidHealth targetHealth = other.GetComponent<AsteroidHealth>();
            AsteroidMovement targetSpeed = other.GetComponent<AsteroidMovement>();

            if (targetHealth.getHealth() % numberValue == 0)
            {
                targetHealth.takeDamage(numberValue);
            }
            else
            {
                targetSpeed.ChangeSpeed(speedMultiplier);
            }
        }
        else if(other.ToString().Contains("AlienShip"))
        {
            gameObject.transform.position = new Vector2(15, 20);
            Destroy(gameObject, 0.5f);
        }
        else if(other.ToString().Contains("Power"))
        {
            gameObject.transform.position = new Vector2(15, 20);
            Destroy(gameObject, 0.5f);
        }
    }

    public void ChangeSpeed(float multiplier)
    {
        missileSpeed *= multiplier;
    }

}

