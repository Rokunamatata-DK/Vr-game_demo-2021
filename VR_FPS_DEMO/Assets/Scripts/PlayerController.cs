using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject O_Bullet;

    GameObject O_MainCamera;
    CameraController S_CameraScript;
    float F_LeftMouseDownTimer = 0.0f;
    float F_RightMouseDownTimer = 0.0f;


    void Start()
    {
        //get camera rotation for bullet base rotation & position
        O_MainCamera = GameObject.Find("Main Camera");
        S_CameraScript = O_MainCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            F_LeftMouseDownTimer += Time.deltaTime ;
            
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
            
            // set maximum value player can get by holding mouse button;
            F_LeftMouseDownTimer = Mathf.Clamp(F_LeftMouseDownTimer, 0.0f, 2.0f);
            print(F_LeftMouseDownTimer);
            //create game object whenever key is released
            Vector3 V_BulletLocation = S_CameraScript.T_CameraTransform.position + S_CameraScript.T_CameraTransform.forward;
            Quaternion Q_BulletRotation = S_CameraScript.T_CameraTransform.rotation;
            GameObject Bullet = Instantiate(O_Bullet, V_BulletLocation, Q_BulletRotation);
            //noot to reverse bullet
            Bullet.GetComponent<BulletController>().B_ReverveCurve = false;
            Bullet.GetComponent<BulletController>().F_MouseDownTimer = F_LeftMouseDownTimer;

            //reset timer
            F_LeftMouseDownTimer = 0.0f;

            Destroy(Bullet, 2.0f);
        }
        if (Input.GetMouseButton(1))
        {
            F_RightMouseDownTimer += Time.deltaTime;

        }
        else if (Input.GetMouseButtonUp(1))
        {

            // set maximum value player can get by holding mouse button;
            F_RightMouseDownTimer = Mathf.Clamp(F_RightMouseDownTimer, 0.0f, 2.0f);
            print(F_RightMouseDownTimer);

            //create game object whenever key is pressed

            Vector3 V_BulletLocation = S_CameraScript.T_CameraTransform.position + S_CameraScript.T_CameraTransform.forward;
            Quaternion Q_BulletRotation = S_CameraScript.T_CameraTransform.rotation;
            GameObject Bullet = Instantiate(O_Bullet, V_BulletLocation, Q_BulletRotation);
            //reverse bullet curve for right mouse button
            Bullet.GetComponent<BulletController>().B_ReverveCurve = true;
            Bullet.GetComponent<BulletController>().F_MouseDownTimer = F_RightMouseDownTimer;

            //reset timer
            F_RightMouseDownTimer = 0.0f;

            Destroy(Bullet, 2.0f);
        }
    }
}
