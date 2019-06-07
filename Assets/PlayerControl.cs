using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Vector2 pos;
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(-8, 0);
        transform.position = pos;

        speed = 10;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float vel_x = Input.GetAxis("Horizontal");
        float vel_y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(vel_x, vel_y);

        rb.velocity = movement * speed;
    }

    public void checkStatus()
    {

    }
}
