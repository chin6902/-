using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher2 : MonoBehaviour
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
        SceneManager.LoadScene("Stage2");
    }
}