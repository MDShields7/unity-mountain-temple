using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour
{
    public GameObject sceneCenter;
    public float speed;

    public Animator moveCam;
    public bool cubeUp;

    private Vector3 point;


    // Start is called before the first frame update
    void Start()
    {
        if (null != sceneCenter)
        {
            sceneCenter = GameObject.Find("sceneCenter");
        }
        point = sceneCenter.transform.position;

        moveCam = gameObject.GetComponent<Animator>();
        cubeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(point, Vector3.up, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(point, Vector3.down, speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != moveCam && cubeUp == false)
            {
                moveCam.Play("RaiseUp");
                cubeUp = true;
            }
            else if (null != moveCam && cubeUp == true)
            {
                moveCam.Play("FallDn");
                cubeUp = false;
            }
        }

    }
}
