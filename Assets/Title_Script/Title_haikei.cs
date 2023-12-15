using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // 右方向に移動する
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
