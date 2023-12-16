using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Guy : MonoBehaviour
{
    public Rigidbody2D rb;
    public int force = 5;
    public SpriteRenderer sprite;
    public bool canJump;
    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckJump();
        CheckLeft();
        CheckRight();
        CheckDeath();
        if (rb.velocity.x > 3)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
        if (rb.velocity.x < -3)
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
        }
        if (transform.position.x < -8.4)
        {
            transform.position = new Vector2(-8.45f, transform.position.y);
        }
        if (transform.position.x > 8.4)
        {
            transform.position = new Vector2(8.45f, transform.position.y);
        }

    }

    void CheckJump()
    {
        if(Input.GetKeyDown(KeyCode.W) && canJump){
            rb.AddForce(new Vector2(0, 70*force));
        }
    }

    void CheckLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
            rb.AddForce(new Vector2(-force,  0));
        }
    }

    void CheckRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
            rb.AddForce(new Vector2(force, 0));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        canJump = true;


        if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.magenta)
        {
            dead = true;
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (FindObjectOfType<Pink_Button>() != null && FindObjectOfType<Green_Button_Top>() != null
            && FindObjectOfType<Pink_Girl>() != null && FindObjectOfType<Green_Button_Bottom>() != null &&
            FindObjectOfType<Green_Jewel>() != null && FindObjectOfType<Pink_Jewel>() != null)
        {
            if (collision.gameObject.name != FindObjectOfType<Pink_Button>().name && collision.gameObject.name != FindObjectOfType<Green_Button_Top>().name
                && collision.gameObject.name != FindObjectOfType<Pink_Girl>().name && collision.gameObject.name != FindObjectOfType<Green_Button_Bottom>().name
                && collision.gameObject.name != FindObjectOfType<Green_Jewel>().name && collision.gameObject.name != FindObjectOfType<Pink_Jewel>().name)
            {
                canJump = false;
            }
        }


    }

    void CheckDeath()
    {
        if (dead == true)
        {
            Destroy(gameObject);
            UI_2.gameOver(false);
            FindObjectOfType<UI_2>().playDeathSound();
            dead = false;
        }

    }

}
