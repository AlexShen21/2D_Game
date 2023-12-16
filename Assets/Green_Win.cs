using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Win : MonoBehaviour
{
    public bool win = false;
    public AudioSource audioSource;
    public AudioClip victory;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Pink_Win door = FindObjectOfType<Pink_Win>();

        if (win && door.win)
        {
            UI_2.gameOver(true);
            audioSource.PlayOneShot(victory);

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == FindObjectOfType<Green_Guy>().name)
        {
            win = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (FindObjectOfType<Green_Guy>() != null)
        {
            if (collision.gameObject.name == FindObjectOfType<Green_Guy>().name)
            {
                win = false;
            }
        }
    }
}
