using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioClip buttonClickSound; // �{�^���������ꂽ�Ƃ��ɍĐ����鉹���t�@�C��
    private Button button;
    private AudioSource audioSource;

    void Start()
    {
        // �{�^���R���|�[�l���g�̎擾
        button = GetComponent<Button>();

        // Audio Source�R���|�[�l���g�̎擾
        audioSource = GetComponent<AudioSource>();

        // �{�^���������ꂽ�Ƃ��̃C�x���g�n���h���̓o�^
        button.onClick.AddListener(PlayButtonClickSound);
    }

    void PlayButtonClickSound()
    {
        // �������Đ�
        audioSource.PlayOneShot(buttonClickSound);
    }
}
