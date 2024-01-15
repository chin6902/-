using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�ǉ��I�I

public class BGMManager : MonoBehaviour
{
    //�V���O���g���ݒ肱������
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
    //�V���O���g���ݒ肱���܂�




    public AudioSource A_BGM;//AudioSource�^�̕ϐ�A_BGM��錾�@�Ή�����AudioSource�R���|�[�l���g���A�^�b�`
    public AudioSource B_BGM;//AudioSource�^�̕ϐ�B_BGM��錾�@�Ή�����AudioSource�R���|�[�l���g���A�^�b�`
    public AudioSource C_BGM;
    public AudioSource D_BGM;
    public AudioSource E_BGM;

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 

    void Start()
    {
        beforeScene = "MainMenu";//�N�����̃V�[���� �������Ă���
        A_BGM.Play();//A_BGM��AudioSource�R���|�[�l���g�Ɋ��蓖�Ă�AudioClip���Đ�

        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }




    //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h�@
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        if (beforeScene == "StageSelect" && nextScene.name == "Stage1")
        {
            A_BGM.Stop();
            B_BGM.Play();
        }

        // Scene1����Scene2��
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


        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }
}
