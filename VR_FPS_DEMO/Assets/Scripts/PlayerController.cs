using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject O_Bullet;

    GameObject O_MainCamera;
    CameraController S_CameraScript;


    void Start()
    {
        //get camera rotation for bullet base rotation & position
        O_MainCamera = GameObject.Find("Main Camera");
        S_CameraScript = O_MainCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //create game object whenever key is pressed

            

            Vector3 V_BulletLocation = S_CameraScript.T_CameraTransform.position + S_CameraScript.T_CameraTransform.forward;
            Quaternion Q_BulletRotation = S_CameraScript.T_CameraTransform.rotation;
            GameObject Bullet = Instantiate(O_Bullet, V_BulletLocation, Q_BulletRotation);
            //Bullet.transform.position = this.transform.position + transform.forward;
            //Bullet.transform.rotation = this.transform.rotation;

            Destroy(Bullet, 2.0f);
        }
    }
}
