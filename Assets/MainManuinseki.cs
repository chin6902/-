using UnityEngine;

public class MainMenuinseki : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Z座標を負の値に設定してCanvasの背後に配置
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(-1, -1, 0).normalized;
        Vector3 movement = moveDirection * speed * Time.deltaTime;

        // オブジェクトを移動させる
        transform.Translate(movement, Space.World);
    }
}
