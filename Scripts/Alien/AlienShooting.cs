using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShooting : MonoBehaviour
{
    public int fire_Rate;
    public int offset;
    public Rigidbody2D laser;

    private int counter;

    void Update()
    {
        counter++;
        if((counter + offset)%fire_Rate == 0 && Time.timeScale > 0f)
        {
            Fire();
        }
        if(counter == fire_Rate)
        {
            counter = 0;
        }
    }

    private void Fire()
    {
        Rigidbody2D laserInstance = Instantiate(laser, new Vector3(transform.position.x, transform.position.y - 0.2f, 0), Quaternion.identity) as Rigidbody2D;
    }
}
