﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletspeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
