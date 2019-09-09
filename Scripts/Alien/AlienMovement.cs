using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float x_pos1;
    public float y_pos1;
    public float x_pos2;
    public float y_pos2;
    public float alienSpeedx;//must be positive
    public float alienSpeedy;

    private Rigidbody2D alienRigidbody;
    private float x_direction;//+ve if going from left to right
    private float y_direction;//+ve if going from down to up

    void Start()
    {
        alienRigidbody = GetComponent<Rigidbody2D>();
        alienRigidbody.MovePosition(new Vector2(x_pos1, y_pos1));
        if(x_pos2 >= x_pos1)
        {
            x_direction = 1f;
        }
        else
        {
            x_direction = -1f;
        }
        if(y_pos2 >= y_pos1)
        {
            y_direction = 1f;
        }
        else
        {
            y_direction = -1f;
        }
    }

    void Update()
    {
        alienRigidbody.MovePosition(new Vector2(transform.position.x + x_direction * alienSpeedx * Time.deltaTime, transform.position.y + y_direction * alienSpeedy * Time.deltaTime));

        if((transform.position.x >= x_pos2 && x_pos2 >= x_pos1) || (transform.position.x >= x_pos1 && x_pos1 >= x_pos2))
        {
            x_direction = -1f;
        }
        if((transform.position.x <= x_pos2 && x_pos2 <= x_pos1)|| (transform.position.x <= x_pos1 && x_pos1 <= x_pos2))
        {
            x_direction = 1f;
        }
        if((transform.position.y >= y_pos2 && y_pos2 >= y_pos1) || (transform.position.y >= y_pos1 && y_pos1 >= y_pos2))
        {
            y_direction = -1f;
        }
        if((transform.position.y <= y_pos2 && y_pos2 <= y_pos1) || (transform.position.y <= y_pos1 && y_pos1 <= y_pos2))
        {
            y_direction = 1f;
        }
    }
}
