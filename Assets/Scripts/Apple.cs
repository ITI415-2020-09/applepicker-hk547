using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    //declares and defines a static varuable named bottomY
    //static shares all values from class

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //destroy fuction removes things that are passed into it from the game

            //get a reference to the applepicker component of main camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //call the public appledestroyed() method of apscript
            apScript.AppleDestroyed();
        }
    }
}
