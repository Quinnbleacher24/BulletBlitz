using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public BoxCollider2D Top_Wall;
    public BoxCollider2D bottom;
    public BoxCollider2D left;
    public BoxCollider2D right;

    public EnemyControl enemyPrefab;
    public PlayerControl playerPrefab;

    
    public List<EnemyControl> enemies;
    public int wave;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<EnemyControl>();
        wave = 0;
        setWallColliders();
        Instantiate(playerPrefab);
    }

    void Update()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].dead)
            {
                Destroy(enemies[i].gameObject);
                enemies.RemoveAt(i);
            }
        }

        if (allEnemiesDead())
        {
            wave++;
            for (int i = 0; i < wave; i++)
            {
                enemies.Add(Instantiate(enemyPrefab));
            }
        }
    }

    void setWallColliders()
    {
        Vector3 ScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));

        Top_Wall.size = new Vector2(ScreenSize.x, 1f);
        Top_Wall.offset = new Vector2(-ScreenSize.x / 2, ScreenSize.y + 0.5f);

        bottom.size = new Vector2(ScreenSize.x, 1f);
        bottom.offset = new Vector2(-ScreenSize.x / 2, -0.5f - ScreenSize.y);

        left.size = new Vector2(1f, ScreenSize.y * 2);
        left.offset = new Vector2(-0.5f - ScreenSize.x, 0f);

        right.size = new Vector2(1f, ScreenSize.y * 2);
        right.offset = new Vector2(0.5F, 0f);
    }

    bool allEnemiesDead()
    {
        for(int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].dead)
            {
                return false;
            }
        }
        return true;
    }
}
