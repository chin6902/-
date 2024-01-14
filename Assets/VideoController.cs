using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // “®‰æI—¹‚Ìˆ—
        SceneManager.LoadScene("MainMenu"); // Ÿ‚ÌƒV[ƒ“‚ÉØ‚è‘Ö‚¦‚é
    }
}
