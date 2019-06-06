using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Vector2 pos;
    public float speed = 0.1F;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(-8, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        transform.position = pos;
    }

    void Move()
    {
        float vel_x = Input.GetAxis("Horizontal");
        float vel_y = Input.GetAxis("Vertical");

        pos += new Vector2(vel_x, vel_y) * speed;
    }
}
