using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 2.45)
        {
            rb.velocity = new Vector2(-1, 0);
        }
        else if (transform.position.x <= -2.45)
        {
            rb.velocity = new Vector2(1, 0);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collide = collision.collider;

        if (FindObjectOfType<Green_Guy>() != null && FindObjectOfType<Pink_Girl>() != null)
            if(collide.gameObject.name == FindObjectOfType<Green_Guy>().name)
            {
                FindObjectOfType<Green_Guy>().dead = true;
            }
            else if(collide.gameObject.name == FindObjectOfType<Pink_Girl>().name)
            {
                FindObjectOfType<Pink_Girl>().dead = true;
            }

    }
}
