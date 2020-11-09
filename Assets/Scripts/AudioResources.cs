using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioResources : MonoBehaviour {

  private static AudioResources instance;
  public static AudioResources Instance {
    get {
      if (instance == null) {
        instance = FindObjectOfType<AudioResources>( );
        if (instance == null) {
          instance = new GameObject("New AudioResources", typeof(AudioResources)).GetComponent<AudioResources>( );
        }
      }
      return instance;
    }
  }

  public SoundClip[] audioClips;

  [System.Serializable]
  public class SoundClip {
    // A class to better conrol all the audios
    public AudioManager.SoundType type;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume = 0.5f;
  }

}
