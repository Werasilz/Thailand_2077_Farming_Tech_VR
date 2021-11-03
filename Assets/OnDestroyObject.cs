using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Werasilz
{
    public class OnDestroyObject : MonoBehaviour
    {
        AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void LateUpdate()
        {
            if (audioSource.isPlaying == false)
            {
                Destroy(gameObject);
            }
        }

        private void OnDestroy()
        {
            SoundManager.instance.isPlaying = false;
        }
    }
}
