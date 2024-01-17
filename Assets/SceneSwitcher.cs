using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // �}�E�X�̍��N���b�N�����ꂽ�����m�F
        if (Input.GetMouseButtonDown(0))
        {
            // �N���b�N���ꂽ��MainMenu�V�[���ɐ؂�ւ���
            SwitchToMainMenu();
        }
    }

    void SwitchToMainMenu()
    {
        // MainMenu�V�[���̖��O���w�肵�ă��[�h
        SceneManager.LoadScene("MainMenu");
    }
}
