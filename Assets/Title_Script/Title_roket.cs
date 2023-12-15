using UnityEngine;

public class MoveToTopRight : MonoBehaviour
{
    public float speed = 10f; // 移動速度
    private Vector3 initialPosition;

    void Start()
    {
        // 初期位置を保存
        initialPosition = transform.position;
    }

    void Update()
    {
        // オブジェクトを右上に移動するためのベクトルを作成
        Vector3 moveDirection = new Vector3(1, 1, 0).normalized;

        // 移動ベクトルに速度を乗算してフレームごとの移動量を計算
        Vector3 movement = moveDirection * speed * Time.deltaTime;

        // オブジェクトの座標を更新
        transform.Translate(movement, Space.World); // Space.Worldを指定してワールド座標で移動

        // 画面外に出たらオブジェクトを破棄
        if (!IsObjectVisible())
        {
            Destroy(gameObject);
        }
    }

    // オブジェクトが画面内にあるかどうかを判定するメソッド
    bool IsObjectVisible()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);
        return (viewportPos.x >= 0 && viewportPos.x <= 1 && viewportPos.y >= 0 && viewportPos.y <= 1);
    }
}

