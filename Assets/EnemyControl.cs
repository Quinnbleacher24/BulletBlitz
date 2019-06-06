using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Vector2 pos;
    public Vector2 vel;
    public float speed = 0.05F;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {

        pos = new Vector2(8, 2);
        vel = setDirection();
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        transform.position = pos;
    }

    void Move()
    {
        pos += vel * speed;
    }

    Vector2 setDirection()
    {
        Vector2 player_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 distance = player_pos - pos;
        return distance / distance.magnitude;
    }
}
