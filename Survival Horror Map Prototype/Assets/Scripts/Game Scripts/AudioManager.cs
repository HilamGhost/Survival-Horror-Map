using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HilamPrototype
{
    public class AudioManager : Singleton<AudioManager>
    {
        [SerializeField] AudioSource defaultAudioManager;

       
        public void PlayAudioOneShot(AudioClip _audio) 
        {
            if(_audio != null) defaultAudioManager.PlayOneShot(_audio);
        }
        public void PlayAudioOneShot(AudioClip _audio, AudioSource _audioSource) 
        {
            if (_audio != null)  _audioSource.PlayOneShot(_audio);
        }
    }
}
