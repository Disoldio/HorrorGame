using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private float clamp = 75f;

    private Rigidbody rb;
    private float x,y = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
    }
    private void Update()
    {
        rb.linearVelocity = currentVelocity();


        cam.transform.localRotation = calcCameraRotation();
        transform.rotation = calcBodyRotation();
    }

    private Vector3 currentVelocity() {
        Vector3 vertical = gameObject.transform.forward * speed * Input.GetAxisRaw("Vertical");
        Vector3 horizontal = gameObject.transform.right * speed * Input.GetAxisRaw("Horizontal");

        return vertical + horizontal + Physics.gravity;
    }

    private Quaternion calcCameraRotation() {
        y -= Input.GetAxis("Mouse Y");
        y = Mathf.Clamp(y, -clamp, clamp);

        return Quaternion.Euler(y, cam.transform.rotation.y, 0);
    }

    private Quaternion calcBodyRotation() {
        x += Input.GetAxis("Mouse X");
        return Quaternion.Euler(transform.rotation.x, x, 0);
    }
}
