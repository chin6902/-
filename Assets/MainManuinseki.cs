using UnityEngine;

public class MainMenuinseki : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Z���W�𕉂̒l�ɐݒ肵��Canvas�̔w��ɔz�u
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(-1, -1, 0).normalized;
        Vector3 movement = moveDirection * speed * Time.deltaTime;

        // �I�u�W�F�N�g���ړ�������
        transform.Translate(movement, Space.World);
    }
}
