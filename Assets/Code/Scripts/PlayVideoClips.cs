using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoClips : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] VideoClip[] videoClips;
    private int currentClipIndex = 0;

    private void Awake() {
        videoPlayer.clip = videoClips[currentClipIndex];
    }

    private void Start() {
        videoPlayer.Play();
        StartCoroutine(PlayNextVideo());
    }
    IEnumerator PlayNextVideo() {
        while (true) { 
            if (currentClipIndex > videoClips.Length) {
                currentClipIndex = 0;
            }
            yield return new WaitForSeconds((float)videoPlayer.clip.length);
            currentClipIndex++;
            videoPlayer.clip = videoClips[currentClipIndex];
            videoPlayer.Play();
        }
    }
}
