using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
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
        // MainMenuシーンの名前を指定してロード
        SceneManager.LoadScene("MainMenu");
    }
}
