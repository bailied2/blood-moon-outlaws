using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunAim : MonoBehaviour
{
    Vector2 mousePos = Vector2.zero;
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - new Vector2(transform.position.x, transform.position.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);

        Vector3 scale = transform.localScale;
        scale.y = (mousePos.x < transform.position.x) ? -1 : 1;
        transform.localScale = scale;
    }
}
