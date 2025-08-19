using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private float clamp = 75f;

    private float x, y = 0f;
    private void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
    }
    private void Update()
    {
        cam.transform.localRotation = calcCameraRotation();
        transform.rotation = calcBodyRotation();
    }
    private Quaternion calcCameraRotation()
    {
        y -= Input.GetAxis("Mouse Y");
        y = Mathf.Clamp(y, -clamp, clamp);

        return Quaternion.Euler(y, cam.transform.rotation.y, 0);
    }

    private Quaternion calcBodyRotation()
    {
        x += Input.GetAxis("Mouse X");
        return Quaternion.Euler(transform.rotation.x, x, 0);
    }
}
