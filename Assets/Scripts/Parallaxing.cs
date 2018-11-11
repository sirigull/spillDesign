using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {
    //From Brackeys "How to make a 2D platformer - Parallax Scrolling"

    public Transform[] backgrounds;     //List of all backgrounds to be parallaxed
    private float[] parallaxScales;     //The proportion of the camera@s movement to move the backgrounds by
    public float smoothing = 1f;       //How smooth the parallax is going to be. Must be higher than 0

    private Transform cam;              //reference to the main cameras transform
    private Vector3 previousCamPos;     //The position of the camera in the previous frame

    //Is called before Start()
    void Awake()
    {
        //Set up the reference
        cam = Camera.main.transform;
    }

    // Use this for initialization
    void Start () {
        //The previous frame had the current frame@s camera position
        previousCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];

        //assigning corresponding parallax scales
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update () {
            //for each background
            for (int i = 0; i < backgrounds.Length; i++)
            {
                //the parallax is the opposite of the camera movement because the previous fra me multiplied by the scale
                float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

                //set a target x position which is the current position plus the parallax
                float backgroundTargetPosX = backgrounds[i].position.x + parallax;

                //create a target position which is the backgrounds current position with its target x position
                Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

                //fade between current position and target position
                backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
            }
            //set the previous camPos to the cameras position at the end of the frame
            previousCamPos = cam.position;
    }
}