using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingController : MonoBehaviour
{
    public Animator levitateBldgs;
    public bool cubeUp;
    // Start is called before the first frame update
    void Start()
    {
        cubeUp = false;
        levitateBldgs = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != levitateBldgs && cubeUp == false)
            {
                levitateBldgs.Play("Rise2");
                cubeUp = true;
            }
            else if (null != levitateBldgs && cubeUp == true)
            {
                levitateBldgs.Play("Fall2");
                cubeUp = false;
            }
        }
    }
}