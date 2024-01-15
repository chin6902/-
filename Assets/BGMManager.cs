using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //追加！！

public class BGMManager : MonoBehaviour
{
    //シングルトン設定ここから
    static public BGMManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    //シングルトン設定ここまで




    public AudioSource A_BGM;//AudioSource型の変数A_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ
    public AudioSource B_BGM;//AudioSource型の変数B_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ
    public AudioSource C_BGM;
    public AudioSource D_BGM;
    public AudioSource E_BGM;

    private string beforeScene;//string型の変数beforeSceneを宣言 

    void Start()
    {
        beforeScene = "MainMenu";//起動時のシーン名 を代入しておく
        A_BGM.Play();//A_BGMのAudioSourceコンポーネントに割り当てたAudioClipを再生

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }




    //シーンが切り替わった時に呼ばれるメソッド　
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定
        if (beforeScene == "StageSelect" && nextScene.name == "Stage1")
        {
            A_BGM.Stop();
            B_BGM.Play();
        }

        // Scene1からScene2へ
        if (beforeScene == "StageSelect" && nextScene.name == "Stage2")
        {
            A_BGM.Stop();
            C_BGM.Play();
        }

        if (beforeScene == "StageSelect" && nextScene.name == "stage3")
        {
            A_BGM.Stop();
            D_BGM.Play();
        }

        if (beforeScene == "Stage1" && nextScene.name == "MainMenu")
        {
            B_BGM.Stop();
            A_BGM.Play();
        }

        if (beforeScene == "Stage2" && nextScene.name == "MainMenu")
        {
            C_BGM.Stop();
            A_BGM.Play();
        }

        if (beforeScene == "stage3" && nextScene.name == "MainMenu")
        {
            D_BGM.Stop();
            A_BGM.Play();
        }

        if (beforeScene == "MainMenu" && nextScene.name == "Challenge")
        {
            A_BGM.Stop();
            E_BGM.Play();
        }

        if (beforeScene == "Challenge" && nextScene.name == "MainMenu")
        {
            E_BGM.Stop();
            A_BGM.Play();
        }

        if (beforeScene == "ending1" && nextScene.name == "MainMenu")
        {
            E_BGM.Stop();
            A_BGM.Play();
        }

        if (beforeScene == "ending2" && nextScene.name == "MainMenu")
        {
            E_BGM.Stop();
            A_BGM.Play();
        }


        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }
}
