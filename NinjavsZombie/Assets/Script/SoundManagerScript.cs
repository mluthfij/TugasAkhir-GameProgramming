using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerHurtSound, fireSound, zombieSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerHurtSound = Resources.Load<AudioClip>("playerHurt");   
        fireSound = Resources.Load<AudioClip>("fire");   
        zombieSound = Resources.Load<AudioClip>("zombie");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "playerHurt":
                audioSrc.PlayOneShot(playerHurtSound);
                break;
            case "fire":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "zombie":
                audioSrc.PlayOneShot(zombieSound);
                break;
        }
    }
}
