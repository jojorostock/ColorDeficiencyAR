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

    void redColor()
    {
        Image pan = GetComponent<Image>();
        pan.color = new Color(255,0, 0, .4f);

    }

    void blueColor()
    {
        Image pan = GetComponent<Image>();
        pan.color = new Color(0, 0,255, .4f);

    }

    void greenColor()
    {
        Image pan = GetComponent<Image>();
        pan.color = new Color(0,255,0, .4f);
    }
}
