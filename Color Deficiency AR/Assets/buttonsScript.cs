using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class buttonsScript : MonoBehaviour
{
    public Button red;
    public Button blue;
    public Button green;
    // Start is called before the first frame update
    void Start()
    {
        Button redButton = red.GetComponent<Button>();
		redButton.onClick.AddListener(redColor);
        Button blueButton = blue.GetComponent<Button>();
	    blueButton.onClick.AddListener(blueColor);
        Button greenButton = green.GetComponent<Button>();
		greenButton.onClick.AddListener(greenColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void disableToggles()
    {
        red.GetComponent<Image>().color = new Color(255, 255, 255);
        blue.GetComponent<Image>().color = new Color(255, 255, 255);
        green.GetComponent<Image>().color = new Color(255, 255, 255);
    }

    void redColor()
    {
        disableToggles();
        Image pan = GetComponent<Image>();
        if (pan.color == new Color(255, 0, 0, .4f))
        {
            pan.color = new Color(255, 255, 255, 0f);
        }
        else {
            pan.color = new Color(255, 0, 0, .4f);
            red.GetComponent<Image>().color = new Color(255, 0, 0);
        }
    }

    void blueColor()
    {
        disableToggles();
        Image pan = GetComponent<Image>();
        if (pan.color == new Color(0, 0, 255, .4f))
        {
            pan.color = new Color(255, 255, 255, 0f);
        }
        else
        {
            pan.color = new Color(0, 0, 255, .4f);
            blue.GetComponent<Image>().color = new Color(0, 0, 255);
        }
    }

    void greenColor()
    {
        disableToggles();
        Image pan = GetComponent<Image>();
        if (pan.color == new Color(0, 255, 0, .4f))
        {
            pan.color = new Color(255, 255, 255, 0f);
        }
        else
        {
            pan.color = new Color(0, 255, 0, .4f);
            green.GetComponent<Image>().color = new Color(0, 255, 0);
        }
    }
}
