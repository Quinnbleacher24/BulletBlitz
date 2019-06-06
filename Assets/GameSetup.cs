using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public BoxCollider2D Top_Wall;
    public BoxCollider2D bottom;
    public BoxCollider2D left;
    public BoxCollider2D right;

    public EnemyControl enemy;
    public PlayerControl player;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 ScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));

        Top_Wall.size = new Vector2(ScreenSize.x * 2, 1f);
        Top_Wall.offset = new Vector2(0f, ScreenSize.y + 0.5f);

        bottom.size = new Vector2(ScreenSize.x * 2, 1f);
        bottom.offset = new Vector2(0f, -0.5f - ScreenSize.y);

        left.size = new Vector2(1f, ScreenSize.y * 2);
        left.offset = new Vector2(-0.5f - ScreenSize.x, 0f);

        right.size = new Vector2(1f, ScreenSize.y * 2);
        right.offset = new Vector2(ScreenSize.x + 0.5f, 0f);


        Instantiate(enemy);
        Instantiate(player);
    }

    void Update()
    {
        
    }
}
