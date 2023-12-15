using UnityEngine;

public class ObjectFlow : MonoBehaviour
{
    public float speed = 5f; // オブジェクトの流れる速さ
    private Vector3 initialPosition;
    private bool movingUpwards = false;

    void Start()
    {
        // 初期位置を保存
        initialPosition = transform.position;
    }

    void Update()
    {
        // オブジェクトを左斜め下または上に移動する
        Vector3 direction = movingUpwards ? Vector3.up : new Vector3(-1, -1, 0);
        transform.Translate(direction * speed * Time.deltaTime);

        // 移動方向の切り替え
        if (IsObjectOutsideScreen())
        {
            movingUpwards = !movingUpwards;
            ResetObjectPosition();
        }
    }

    bool IsObjectOutsideScreen()
    {
        // 画面外に出たかどうかを判定
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        return screenPos.x < 0 || screenPos.y < -6;
    }

    void ResetObjectPosition()
    {
        // 画面外に出たら初期位置に戻す
        transform.position = initialPosition;
    }
}
