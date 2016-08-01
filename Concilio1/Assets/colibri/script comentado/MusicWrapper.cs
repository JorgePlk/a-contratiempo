/* @Author: Gkxd
 * 
 * A wrapper for attaching information to Audio Sources and controlling music loops
 * 
 * */
using UnityEngine;
using System.Collections;

namespace Rhythmify {
    public class MusicWrapper : MonoBehaviour {
        public int BPM;
        private AudioSource audioSource;
        private AudioClip audioClip;
    
        public void Start() {
            if (gameObject.tag != "Rhythmify_Music") {
                Debug.LogError("GameObjects with a MusicWrapper component must be tagged \"Rhythmify_Music\".");
                Debug.Break();
            }

            audioSource = gameObject.GetComponent<AudioSource>();
            audioClip = audioSource.clip;
        }
    }
}