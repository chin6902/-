using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher1: MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        // �}�E�X�̍��N���b�N�����ꂽ�����m�F
        if (Input.GetMouseButtonDown(0))
        {
            // �N���b�N���ꂽ��MainMenu�V�[���ɐ؂�ւ���
            SwitchToMainMenu();
        }
    }

    public void SwitchToMainMenu()
    {
        StartCoroutine(Next());
    }
    IEnumerator Next()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Stage1");
    }
}
