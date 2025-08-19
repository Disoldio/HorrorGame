using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.linearVelocity = currentVelocity();
    }
    private Vector3 currentVelocity() {
        Vector3 vertical = gameObject.transform.forward * speed * Input.GetAxisRaw("Vertical");
        Vector3 horizontal = gameObject.transform.right * speed * Input.GetAxisRaw("Horizontal");

        return vertical + horizontal + Physics.gravity;
    }
}
