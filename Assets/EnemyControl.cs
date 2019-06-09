using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Vector2 vel;
    public float speed;
    public bool dead;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 spawn = new Vector2(10, Random.Range(-6F, 6F));
        transform.position = spawn;

        vel = setDirection(spawn);
        dead = false;
        speed = 7;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = vel * speed;
    }

    Vector2 setDirection(Vector2 pos)
    {
        Vector2 player_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 distance = player_pos - pos;
        return distance / distance.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyIgnoresCollider" || collision.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        else
        {
            dead = true;
        }
    }
}
