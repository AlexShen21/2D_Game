using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Button_Top : MonoBehaviour
{
    Green_Diagonal green_diagonal;
    // Start is called before the first frame update
    void Start()
    {
        green_diagonal = FindObjectOfType<Green_Diagonal>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collide = collision.collider;

        if (collide.gameObject.name == FindObjectOfType<Green_Guy>().name)
        {
            green_diagonal.setInactive();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        green_diagonal.setActive();
    }

}
