using UnityEngine;
using UnityEngine.Video;

public class PlayVideoClipsWeb : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] string[] videoClips;

    private void Awake() {
        videoPlayer.url = videoClips[0];
    }
    public void PlayOnFound() {
        videoPlayer.Play();
    }
    public void Play(int idx) {
        videoPlayer.url = videoClips[idx];
        videoPlayer.Play();
    }
}
