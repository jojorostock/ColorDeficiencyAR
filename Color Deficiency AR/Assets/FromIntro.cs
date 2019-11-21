using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class FromIntro : MonoBehaviour
{

    public Button nextScene;
    // Start is called before the first frame update
    void Start()
    {
        Button toMain = nextScene.GetComponent<Button>();
        toMain.onClick.AddListener(advanceScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void advanceScene()
    {
        SceneManager.LoadScene (sceneName:"MainScene");
    }
}
