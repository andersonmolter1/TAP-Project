using UnityEngine;
using System.Collections;

public class spriteFader : MonoBehaviour
{
    
    public float fadeSpeed = 1f;
    public float fadeTime = 1f;
    public bool fadeIn = true;
    public SpriteRenderer text;

    // Update is called once per frame
    void Update()
    {


        if (fadeIn)
        {
            //float Fade = Mathf.SmoothDamp(0f, 1f, fadeSpeed, fadeTime);
            //text.color = new Color(1f, 1f, 1f, Fade);
        }

        if (!fadeIn)
        {
            //float Fade = Mathf.SmoothDamp(1f, 0f, fadeSpeed, fadeTime);
            //text.color = new Color(1f, 1f, 1f, Fade);
        }
    }
}