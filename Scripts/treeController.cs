using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeController : MonoBehaviour
{
    public Animator levitateTrees;
    public bool cubeUp;
    // Start is called before the first frame update
    void Start()
    {
        cubeUp = false;
        levitateTrees = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != levitateTrees && cubeUp == false)
            {
                levitateTrees.Play("Rise1");
                cubeUp = true;
            }
            else if (null != levitateTrees && cubeUp == true)
            {
                levitateTrees.Play("Fall1");
                cubeUp = false;
            }
        }
    }
}