using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //Public Variables
    public AnimationCurve AC_YCurvePositive;

    float timeElapsed = 0.0f;
    Vector3 startPosition;




    //Variables

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //curve bullet based on curve graph
        timeElapsed += Time.deltaTime;
        //transform.localPosition = new Vector3(transform.position.x + AC_YCurvePositive.Evaluate(timeElapsed), transform.position.y, transform.position.z + 0.1f);
        
        
        transform.position = transform.position + transform.forward * 0.5f;



    }
}
