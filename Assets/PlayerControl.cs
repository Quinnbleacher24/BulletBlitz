using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float pos_x;
    public float pos_y;
    public float vel_x;
    public float vel_y;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        pos_x = -8;
        pos_y = 0;
        vel_x = 0;
        vel_y = 0;
        speed = 0.1F;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pos_x, pos_y);
        Move();
    }

    void Move()
    {
        setDirection();

        pos_x += vel_x * speed;
        pos_y += vel_y * speed;
    }

    void setDirection()
    {
        vel_x = 0;
        vel_y = 0;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            vel_y += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            vel_y -= 1;
        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            vel_x += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            vel_x -= 1;
        }
    }
}
