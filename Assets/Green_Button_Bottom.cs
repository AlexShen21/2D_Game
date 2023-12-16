using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Button_Bottom : MonoBehaviour
{
    public Green_Door door; 
    // Start is called before the first frame update
    void Start()
    {
        door = FindObjectOfType<Green_Door>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collide = collision.collider;

        if(collide.gameObject.name == FindObjectOfType<Green_Guy>().name)
        {
            door.setInactive();
        } 

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        door.setActive();
    }





}
