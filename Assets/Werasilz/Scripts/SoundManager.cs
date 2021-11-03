using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Werasilz
{
    public class SoundManager : MonoBehaviour
    {
        public GameObject audioSpawner;
        public AudioClipContain[] AudioClips;
        public bool isPlaying { get; set; }
        public GameObject pointer;

        public static SoundManager instance { get; private set; }

        private void Awake()
        {
            instance = this;
        }

        private void Update()
        {
            if (isPlaying)
            {
                pointer.gameObject.SetActive(false);
            }
            else
            {
                pointer.gameObject.SetActive(true);
            }
        }

        public void PlayAudio(AudioClip audioClip)
        {
            if (isPlaying == false)
            {
                isPlaying = true;
                GameObject audioSpawn = Instantiate(audioSpawner, Camera.main.transform.position, Quaternion.identity);
                audioSpawn.transform.SetParent(gameObject.transform);
                audioSpawn.GetComponent<AudioSource>().clip = audioClip;
                audioSpawn.GetComponent<AudioSource>().Play();
            }
        }
    }

    [System.Serializable]
    public class AudioClipContain
    {
        [Header("Sound")]
        public AudioClip sound1;
        public AudioClip sound2;
        public AudioClip sound3;
        public AudioClip sound4;
        public AudioClip sound5;
        public AudioClip sound6;
    }
}
