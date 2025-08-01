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

    public void PlayVideos() {
        videoPlayer.Play();
        StartCoroutine(PlayNextVideo());
    }
    IEnumerator PlayNextVideo() {
        while (true) {
            yield return new WaitForSeconds((float)videoPlayer.clip.length);
            currentClipIndex = (currentClipIndex + 1) % videoClips.Length;
            videoPlayer.clip = videoClips[currentClipIndex];
            videoPlayer.Play();
        }
    }
}
