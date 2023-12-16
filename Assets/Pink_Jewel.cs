using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink_Jewel : MonoBehaviour
{
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
            FindObjectOfType<UI_2>().playSound();
            
            UI_2.IncrementScore();
            Destroy(gameObject);
            

            
        }
    }


}
