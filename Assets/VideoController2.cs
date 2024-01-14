using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController2 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button myButton;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // 動画終了時の処理
        myButton.gameObject.SetActive(true); // ボタンをアクティブにする
    }
}
