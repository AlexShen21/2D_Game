using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class UI_2 : MonoBehaviour
{
    public static UI_2 Singleton;
    public int jewels = 0;
    public TextMeshProUGUI jewelText;
    public TextMeshProUGUI gameText;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip deathClip;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        Singleton = this;
        jewelText.text = "Jewels: 0";
        gameText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void IncrementScore()
    {
        Singleton.IncrementScoreInternal();
    }


    private void IncrementScoreInternal()
    {
        jewels+=1;
        jewelText.text = $"Jewels: {jewels}";

    }

    public static void gameOver(bool won)
    {
        Singleton.gameOverInternal(won);
    }


    private void gameOverInternal(bool won)
    {
        if (won && jewels == 4)
        {
            gameText.text = "Congratulations You Win!";
            if (FindObjectOfType<Green_Guy>() != null)
            {
                Destroy(FindObjectOfType<Green_Guy>().gameObject);
            }
            if ((FindObjectOfType<Pink_Girl>() != null))
            {
                Destroy(FindObjectOfType<Pink_Girl>().gameObject);
            }
        }
        else if (!won)
        {
            if (FindObjectOfType<Green_Guy>() != null)
            {
                Destroy(FindObjectOfType<Green_Guy>().gameObject);
            }
            if((FindObjectOfType<Pink_Girl>() != null))
            {
                Destroy(FindObjectOfType<Pink_Girl>().gameObject);
            }
            gameText.text = "You Died!";
        }

    }

    public void playSound()
    {
        source.PlayOneShot(clip);
    }

    public void playDeathSound()
    {
        source.PlayOneShot(deathClip);
    }
}
