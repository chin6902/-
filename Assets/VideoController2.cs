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
        // ����I�����̏���
        myButton.gameObject.SetActive(true); // �{�^�����A�N�e�B�u�ɂ���
    }
}
