using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playerspace;
using Scorespace;
using UnityEditor.TextCore.Text;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    private bool pipe = true;

    [SerializeField] private AudioClip audioDeath, audioFlap, audioHit, audioPass, allahuAudio;
    private void OnEnable()
    {
        Player.onDeath += HitAudio;
        Player.onFlap += FlapAudio;
        PipesScore.onPass += PassAudio;
        Score.OnChangeAudio += ChangeHitAudio;
    }

    private void OnDisable()
    {
        Player.onDeath -= HitAudio;
        Player.onFlap -= FlapAudio;
        PipesScore.onPass -= PassAudio;
        Score.OnChangeAudio -= ChangeHitAudio;
    }
    private void ChangeHitAudio()
    {
        pipe = false;
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
        if (pipe)
        {
            PlayAudio(audioHit);
        }
        else
        {
            AllahuAudio();
        }
    }
    private void AllahuAudio()
    {
        PlayAudio(allahuAudio);
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
