using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public Rigidbody2D missile2;
    public Rigidbody2D missile3;
    public Rigidbody2D missile5;
    public Rigidbody2D missile7;
    public Rigidbody2D missile11;
    public Rigidbody2D missile13;

    private float a_Input, s_Input, d_Input, z_Input, x_Input, c_Input;
    private int counter;
    private bool isDead;

    void Start()
    {
        isDead = false;
    }

    void Update()
    {
        counter++;
        a_Input = Input.GetAxis("2button");
        s_Input = Input.GetAxis("3button");
        d_Input = Input.GetAxis("5button");
        z_Input = Input.GetAxis("7button");
        x_Input = Input.GetAxis("11button");
        c_Input = Input.GetAxis("13button");

        if(a_Input > 0 && counter%15 == 0 && isDead == false)//shoot a 2
        {
            Rigidbody2D missileInstance = Instantiate(missile2, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
        else if(s_Input > 0 && counter%15 == 0 && isDead == false)//shoot a 3
        {
            Rigidbody2D missileInstance = Instantiate(missile3, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
        else if(d_Input > 0 && counter % 15 == 0 && isDead == false)//shoot a 5
        {
            Rigidbody2D missileInstance = Instantiate(missile5, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
        else if(z_Input > 0 && counter % 15 == 0 && isDead == false)//shoot a 7
        {
            Rigidbody2D missileInstance = Instantiate(missile7, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
        else if(x_Input > 0 && counter % 15 == 0 && isDead == false)//shoot a 11
        {
            Rigidbody2D missileInstance = Instantiate(missile11, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
        else if(c_Input > 0 && counter % 15 == 0 && isDead == false)//shoot a 13
        {
            Rigidbody2D missileInstance = Instantiate(missile13, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity) as Rigidbody2D;
            counter = 0;
        }
    }

    public void Death()
    {
        isDead = true;
    }
}
