using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip jumpingSound, damageSound, deathSound, gameOverSound;
    public AudioClip soundClip;
    public AudioClip jump;
    public AudioSource audioSound;
    
    void Start()
    {
        //audioSound.clip = soundClip;
        AudioSource audioSound = GetComponent<AudioSource>();
        jumpingSound = Resources.Load<AudioClip>("JumpSFX");
        jump = Resources.Load<AudioClip>("JumpSFX");
        //damageSound = Resources.Load<AudioClip>("DamageSFX");
        //deathSound = Resources.Load<AudioClip>("DeathSFX");
        //gameOverSound = Resources.Load<AudioClip>("LostInTheSauceSFX");
        audioSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        //audioSound = soundClip;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
                audioSound.PlayOneShot(jumpingSound);
            }
        }
    }

    public void soundEffect(string sound)
    {
        SoundEffects se = new SoundEffects();
        if (sound.Equals("JumpSFX"))
        {
            se.audioSound.PlayOneShot(jumpingSound);
        }
        switch (sound)
        {
            case "JumpSFX":
                se.soundClip = se.jumpingSound;
                se.audioSound.PlayOneShot(jumpingSound);
                print("Sound!");
                break;
                /*
            case "DamageSFX":
                soundClip.PlayOneShot(damageSound);
                break;
            case "DeathSFX":
                soundClip.PlayOneShot(deathSound);
                break;
            case "LostInTheSauceSFX":
                soundClip.PlayOneShot(gameOverSound);
                break;
                */
        }
    }
}
