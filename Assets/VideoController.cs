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
        // ����I�����̏���
        SceneManager.LoadScene("MainMenu"); // ���̃V�[���ɐ؂�ւ���
    }
}
