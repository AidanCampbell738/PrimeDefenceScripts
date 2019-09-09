using UnityEngine;

public class AsteroidHealthBarManager : MonoBehaviour
{
    private int asteroidHealth;
    private float asteroidSpeed;
    private Rigidbody2D healthBarRigid;
    private TextMesh health;

    void Start()
    {
        healthBarRigid = GetComponent<Rigidbody2D>(); 
        asteroidHealth = 10;//default value
        asteroidSpeed = 1f;

        health = GetComponent<TextMesh>();
        health.text = asteroidHealth.ToString();
    }

    void Update()
    {
        if(GameData.asteroidMotion == true)
        {
            healthBarRigid.MovePosition(new Vector2(0, transform.position.y - asteroidSpeed * Time.deltaTime));
        }
        health.text = asteroidHealth.ToString();
    }

    public void UpdateSpeed(float value)
    {
        asteroidSpeed = value;
    }

    public void UpdateHealth(int amount)
    {
        asteroidHealth = amount;
    }
}
