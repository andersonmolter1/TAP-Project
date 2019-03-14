using UnityEngine;

public class musicContinuation: MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}