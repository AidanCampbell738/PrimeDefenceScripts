using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float s_speed;

    private float s_Input;
    private Rigidbody2D s_Rigidbody;

    void Start()
    {
        s_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        s_Input = Input.GetAxis("ShipMvmt");
        s_Rigidbody.MovePosition(new Vector2(transform.position.x + s_Input * s_speed * Time.deltaTime, 0));
    }

    public void ChangeSpeed(float multiplier)
    {
        s_speed *= multiplier;
    }

    public void ResetSpeed(float multiplier)
    {
        s_speed /= multiplier;
    }
}
