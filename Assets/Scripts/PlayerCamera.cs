using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    public float sensitivity = 650f; // Czu�o�� myszy
    public Transform orientation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime; // Ujemne, aby zmienia� k�t patrzenia w g�r� i w d�


        // Patrzenie w g�re i w d�
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        // Patrzenie lewo prawo
        yRotation += mouseX;

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

  

}
