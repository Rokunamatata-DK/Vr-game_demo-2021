using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject O_Bullet;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //create game object whenever key is pressed
            GameObject Bullet = Instantiate(O_Bullet);
            Bullet.transform.position = transform.position + transform.forward;
            Bullet.transform.rotation = transform.rotation;
        }
    }
}
