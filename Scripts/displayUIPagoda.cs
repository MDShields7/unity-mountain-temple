using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

public class displayUIPagoda : MonoBehaviour
{
    public Text myText;
    public string myString;
    public float fadeTime;
    public bool displayInfo;
    public string Colours;

    // Start is called before the first frame update
    void Start()
    {
        //myText.text = "Pagoda";
        myText = GameObject.Find("pagoda").GetComponent<Text>();
        myText.color = Color.clear;
        Colours = myText.color.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.lockState = CursorLockMode.None;
        //}
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        //info.text = "Pagoda";
        displayInfo = true;
    }
    void OnMouseExit()
    {
        displayInfo = false;
    }
    void FadeText ()
    {
        if (displayInfo)
        {
            myText.text = myString;
            //myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
            myText.color = Color.white;
            Colours = myText.color.ToString();
        }
        else
        {
            //myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
            myText.color = Color.clear;
            Colours = myText.color.ToString();
        }

    }
}
