using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Bullet;
    public float offset;
    public float speed;
    [SerializeField]
    float xmin, xmax;
    // Start is called before the first frame update
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if(collision.gameObject==collision.gameObject.tag)
    //}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(xinput, transform.position.y, 0) * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xmin, xmax), 0, 0);
    }
    private void firebullet()
    {
        Bullet.transform.position = new Vector3(transform.position.x, transform.position.y + offset, 0);
     Instantiate(Bullet.transform.position, Quaternion.identity);
    }
}
