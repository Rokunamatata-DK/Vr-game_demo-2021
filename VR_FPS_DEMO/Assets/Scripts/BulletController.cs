using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //Public Variables
    public AnimationCurve AC_YCurvePositive;
    public bool B_ReverveCurve = false;
    public float F_MouseDownTimer = 0.0f;

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
        //transform.localPosition = new Vector3(transform.localPosition.x - AC_YCurvePositive.Evaluate(timeElapsed), transform.localPosition.y, transform.localPosition.z + 0.1f);


        transform.position = transform.position + transform.forward * 0.25f;
        if (B_ReverveCurve)
        {
            transform.position -= transform.right * AC_YCurvePositive.Evaluate(timeElapsed) * (1.0f + F_MouseDownTimer);
        }
        else
        {
            transform.position += transform.right * AC_YCurvePositive.Evaluate(timeElapsed) * (1.0f + F_MouseDownTimer);
        }

    }
}
