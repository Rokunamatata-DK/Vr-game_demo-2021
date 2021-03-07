using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	//Variables
	float f_RotationX;
	float f_RotationY;
    public Transform T_PlayerTransform;
    public bool b_HideCursor = true;

	//overall multi-factor of rotation speed
	public float f_MouseSensitivity = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (b_HideCursor)
        {
            Cursor.visible = false;
            //lock cursor to game window;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
    	//Takes Mouse input, multiply it with sensitivity.
        float f_MouseInputY= Input.GetAxis("Mouse Y") * Time.deltaTime * f_MouseSensitivity * 10; 
        float f_MouseInputX= Input.GetAxis("Mouse X") * Time.deltaTime * f_MouseSensitivity * 10;

        //Rotate Camera with input.
        f_RotationX -= f_MouseInputY;

        //Hard cap up and down rotation to 90 degree up and 90 degree
        f_RotationX = Mathf.Clamp(f_RotationX, -90f, 90f);

        transform.localEulerAngles = new Vector3(f_RotationX, 0f, 0f);

        //Rotate player left and right
        T_PlayerTransform.Rotate(Vector3.up * f_MouseInputX);
        */
    }
}
