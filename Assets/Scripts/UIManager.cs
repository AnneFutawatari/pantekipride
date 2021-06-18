using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	string SelectCharacterTitle;
	string SelectCharacterStage1;
	public Text gameovertext;
	Canvas canvas;
	CameraController cameraController;

	void Start () {
		canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
		cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
		SelectCharacterTitle = SceneManager.GetActiveScene().name;
		SelectCharacterStage1 = SceneManager.GetActiveScene().name;
	}

	//Gameoverになった時の表示
	public void Gameover(){
		gameovertext.text = "廃棄";
		canvas.enabled = true;
		//cameraController.SetGameOver();
	}

    //Goalした時の表示
    public void Goal()
    {
		gameovertext.text = "購入";
		canvas.enabled = true;
	}

	public void BackTitle()
    {
		SceneManager.LoadScene("SelectCharacterTitle");
    }
}