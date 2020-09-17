using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // get current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;
        // camera's position sets how far to push the mose into 3D
        mousePos2D.x = -Camera.main.transform.position.x;
        // convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        // mve the x poosition of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
}
