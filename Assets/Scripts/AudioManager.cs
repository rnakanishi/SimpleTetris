using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Static class to play each sound 
public static class AudioManager {

    private static GameObject oneShotSound;
    private static AudioSource oneShotAudioSource;
    public enum SoundType {
        Background,
        Pause,
        TetrisDrop,
        TetrisSwap,
        ClearLine,
        GameOver
    }

    public static void playMusic(SoundType sound) {

    }

    public static void playSFX(SoundType sound) {
        if (oneShotSound == null) {
            oneShotSound = new GameObject("Sound");
            oneShotAudioSource = oneShotSound.AddComponent<AudioSource>( );
        }
        AudioResources.SoundClip clip = findAudioClip(sound);
        oneShotAudioSource.volume = clip.volume;
        oneShotAudioSource.PlayOneShot(clip.clip);

    }

    private static AudioResources.SoundClip findAudioClip(SoundType type) {
        foreach (AudioResources.SoundClip audio in AudioResources.Instance.audioClips) {
            if (audio.type == type) {
                return audio;
            }
        }
        Debug.Log("Sound " + type + " not found");
        return null;
    }
}
