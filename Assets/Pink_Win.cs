using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink_Win : MonoBehaviour
{
    public bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == FindObjectOfType<Pink_Girl>().name)
        {
            win = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (FindObjectOfType<Pink_Girl>() != null)
        {
            if (collision.gameObject.name == FindObjectOfType<Pink_Girl>().name)
            {
                win = false;
            }
        }
    }
}
