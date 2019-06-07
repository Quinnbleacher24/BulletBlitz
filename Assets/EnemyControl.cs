using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Vector2 pos;
    public Vector2 vel;
    public float speed;
    public bool dead;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(10, Random.Range(-6F, 6F));
        vel = setDirection();
        dead = false;
        speed = 7;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        checkStatus();
        Move();
        transform.position = pos;
    }

    void Move()
    {
        Vector2 movement = vel;

        rb.velocity = movement * speed;
    }

    Vector2 setDirection()
    {
        Vector2 player_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 distance = player_pos - pos;
        return distance / distance.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pos.x < 0)
        {
            dead = true;
        }
    }

    public void checkStatus()
    {
        if(dead)
        {
            Start();
        }
    }
}
