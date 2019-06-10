using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Vector2 pos;
    public float speed;
    public Rigidbody2D rb;

    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(-8, 0);
        transform.position = pos;

        speed = 10;
        rb = GetComponent<Rigidbody2D>();

        dead = false;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            dead = true;
        }
    }

    public void respawn()
    {
        pos = new Vector2(-8, 0);
        transform.position = pos;
    }
}
