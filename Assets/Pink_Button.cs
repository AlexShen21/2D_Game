using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink_Button : MonoBehaviour
{
    public Pink_Diagonal pink_diagonal;
    // Start is called before the first frame update
    void Start()
    {
        pink_diagonal = FindObjectOfType<Pink_Diagonal>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collide = collision.collider;

        if (collide.gameObject.name == FindObjectOfType<Pink_Girl>().name)
        {
            pink_diagonal.setInactive();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        pink_diagonal.setActive();
    }

}
