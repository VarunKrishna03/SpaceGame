using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 2f, 3f);             
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnEnemies()
    {
        transform.position = new Vector3(Random.Range(-7, 7), 5.0f, 0);
        GameObject enemy = Instantiate(Enemy, transform.position, Quaternion.identity);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down;
    }
}
