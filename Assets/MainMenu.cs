using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Stage_1;
    public string Stage_2;
    public string Stage_3;
    public string challenge;
    public string StageSelect;
    public string control;
    public string opening;
    public string Rule_1;
    public string Rule_2;
    public string Rule_3;
    public string Rule_4;


    public void Mainmenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Opening()
    {
        SceneManager.LoadSceneAsync(opening);
    }


    public void Control()
    {
        SceneManager.LoadSceneAsync(control);
    }
    public void Stage()
    {
        SceneManager.LoadSceneAsync(StageSelect);
    }

    public void Stage1()
    {
        SceneManager.LoadScene(Stage_1);
    }

    public void Stage2()
    {
        if (PlayerAttributes.stage1 == true)
        {
            SceneManager.LoadScene(Stage_2);
        }
    }

    public void Stage3()
    {
        if (PlayerAttributes.stage2 == true)
        {
            SceneManager.LoadScene(Stage_3);
        }
    }

    public void Rule1()
    {
        SceneManager.LoadScene(Rule_1);
    }

    public void Rule2()
    {
        if (PlayerAttributes.stage1 == true)
        {
            SceneManager.LoadScene(Rule_2);
        }
    }

    public void Rule3()
    {
        if (PlayerAttributes.stage2 == true)
        {
            SceneManager.LoadScene(Rule_3);
        }
    }

    public void Challenge()
    {
        SceneManager.LoadScene(challenge);
    }

    public void Rule_4Play()
    {
        if(PlayerAttributes.stage1 == true )
        SceneManager.LoadScene(Rule_4);
    }

    
}
