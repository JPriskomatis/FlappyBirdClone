using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playerspace;
using Scorespace;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    [SerializeField] private AudioClip audioDeath, audioFlap, audioHit, audioPass;
    private void OnEnable()
    {
        Player.onDeath += HitAudio;
        Player.onFlap += FlapAudio;
        PipesScore.onPass += PassAudio;
    }

    private void OnDisable()
    {
        Player.onDeath -= HitAudio;
        Player.onFlap -= FlapAudio;
        PipesScore.onPass -= PassAudio;
    }

    private void PassAudio()
    {
        PlayAudio(audioPass);
    }

    private void AudioDeath()
    {
        PlayAudio(audioDeath);
    }
    private void FlapAudio()
    {
        if(GameManager.gameState == GameState.Playing)
        {
            PlayAudio(audioFlap);
        }

    }
    private void HitAudio()
    {
        PlayAudio(audioHit);
    }

    private void PlayAudio(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio clip is missing!");
        }
    }
}
