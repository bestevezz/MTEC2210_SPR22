using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    public float speed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        //Hint: In unity you can get vector direction shorthands like this:
        //Vector3.up etc

        float xVal = speed * Time.deltaTime;
        //Moving in the x direction since x value is in x axis
        transform.Translate(xVal,0,0);

    }
}
