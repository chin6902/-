using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher1: MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        // マウスの左クリックがされたかを確認
        if (Input.GetMouseButtonDown(0))
        {
            // クリックされたらMainMenuシーンに切り替える
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
