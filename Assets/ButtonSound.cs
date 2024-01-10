using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioClip buttonClickSound; // ボタンが押されたときに再生する音声ファイル
    private Button button;
    private AudioSource audioSource;

    void Start()
    {
        // ボタンコンポーネントの取得
        button = GetComponent<Button>();

        // Audio Sourceコンポーネントの取得
        audioSource = GetComponent<AudioSource>();

        // ボタンが押されたときのイベントハンドラの登録
        button.onClick.AddListener(PlayButtonClickSound);
    }

    void PlayButtonClickSound()
    {
        // 音声を再生
        audioSource.PlayOneShot(buttonClickSound);
    }
}
