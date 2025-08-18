using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Camera camera;
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
    void Update()
    {
        Vector3 vertical = gameObject.transform.forward * speed * Input.GetAxisRaw("Vertical");
        Vector3 horizontal = gameObject.transform.right * speed * Input.GetAxisRaw("Horizontal");
        rb.AddForce(vertical + horizontal);

        x += Input.GetAxis("Mouse X");
        y -= Input.GetAxis("Mouse Y");

        y = Mathf.Clamp(y, -clamp, clamp);

        Quaternion camRotation = Quaternion.Euler(y, camera.transform.rotation.y, 0);

        camera.transform.localRotation = camRotation;


        Quaternion objRotation = Quaternion.Euler(transform.rotation.x, x, 0);

        transform.rotation = objRotation;

    }
}
