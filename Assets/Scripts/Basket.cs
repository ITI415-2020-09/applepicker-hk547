﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        //find a reference to the scorecounter gameobject
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        //get the text component of that gameobject
        scoreGT = scoreGo.GetComponent<Text>();
        //get the starting number of points to 0
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        // get current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;
        // camera's position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;
        // convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        // mve the x poosition of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        //Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            //parse the text of the scoreGT into an int
            int score = int.Parse(scoreGT.text);
            //add points for catching the apple
            score += 100;
            //convert the score back to a string and display it
            scoreGT.text = score.ToString();

            //track the high score
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
