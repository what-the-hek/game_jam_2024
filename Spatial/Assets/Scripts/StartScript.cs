using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
   
    public string sceneName = "";
    public Button playButton;

    // void Update()
    // {
    //     if(Input.anyKey)
    //     {
    //         LoadScene();
    //     }
    // }

    // public void LoadScene()
    // {
    //     SceneManager.LoadScene(sceneName);
    // }


	void Start () {
		Button btn = playButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}