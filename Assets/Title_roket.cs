using UnityEngine;

public class MoveToTopRight : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {

        Vector3 moveDirection = new Vector3(1, 1, 0).normalized;


        Vector3 movement = moveDirection * speed * Time.deltaTime;

        transform.Translate(movement, Space.World);
        if (!IsObjectVisible())
        {
            Destroy(gameObject);
        }
    }

    bool IsObjectVisible()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);
        return (viewportPos.x >= 0 && viewportPos.x <= 1 && viewportPos.y >= 0 && viewportPos.y <= 1);
    }
}
