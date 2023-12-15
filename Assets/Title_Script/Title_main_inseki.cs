using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float rotationSpeed = 30f; // 回転速度

    void Update()
    {
        // オブジェクトを無限に回転させる
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
