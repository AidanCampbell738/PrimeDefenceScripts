using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    public int damage;
    public float laserSpeed;
    public float lifespan;
    public AudioSource laserAudio;

    private Rigidbody2D l_Rigidbody;

    void Start()
    {
        l_Rigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifespan);
    }

    void Update()
    {
        l_Rigidbody.MovePosition(new Vector2(0, transform.position.y - laserSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.ToString().Contains("PlayerShip"))
        {
            ShipHealth targetHealth = other.GetComponent<ShipHealth>();
            if(!targetHealth.GetShield())
            {
                targetHealth.takeDamage(damage);
                laserAudio.Play();
            }
            gameObject.transform.position = new Vector2(15, 20);
            Destroy(gameObject, 0.2f);
        }
        else if(other.ToString().Contains("ShieldLaser"))
        {
            Destroy(gameObject, 0.0f);
        }
    }

}
