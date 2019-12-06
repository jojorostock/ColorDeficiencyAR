using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public Button togg;
    // Start is called before the first frame update
    void Start()
    {
        Button toggle = togg.GetComponent<Button>();
		toggle.onClick.AddListener(toggleColor);
    }

    // Update is called once per frame
    void Update()
    {
        // Graphics.Blit(null, m_MyRenderTexture, m_ARBackgroundCamera.material);
    }

    void toggleColor()
    {
        //TODO: have this switch on and off
    }
}
