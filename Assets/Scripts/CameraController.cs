using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 1000f;

    private float xRotation = 0f;

    public Transform playerBody;



    // Start is called before the first frame update
    void Start()
    {
        centerMouse();
    }

    // Update is called once per frame
    void Update()
    {

        float mouseXInput = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseYInput = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseYInput;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseXInput);
    }

    private void centerMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
