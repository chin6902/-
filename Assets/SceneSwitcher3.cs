using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher3 : MonoBehaviour
{
    void Update()
    {
        // マウスの左クリックがされたかを確認
        if (Input.GetMouseButtonDown(0))
        {
            // クリックされたらMainMenuシーンに切り替える
            SwitchToMainMenu();
        }
    }

    void SwitchToMainMenu()
    {
        SceneManager.LoadScene("stage3");
    }
}