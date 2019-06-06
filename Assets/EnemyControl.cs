using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float pos_x;
    public float pos_y;
    public float vel_x;
    public float vel_y;
    public float speed;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        pos_x = 8;
        pos_y = 0;
        speed = 0.05F;
        setDirection();
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pos_x, pos_y);
        Move();
    }

    void Move()
    {
        pos_x += vel_x * speed;
        pos_y += vel_y * speed;
    }

    void setDirection()
    {
        Vector2 player_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float distance = Mathf.Sqrt(Mathf.Pow(player_pos.x - pos_x, 2) + Mathf.Pow(player_pos.y - pos_y, 2));
        vel_x = (player_pos.x - pos_x) / distance;
        vel_y = (player_pos.y - pos_y) / distance;
    }
}
