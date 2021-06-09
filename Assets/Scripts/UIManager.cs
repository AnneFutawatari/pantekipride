using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	
	public Text gameovertext;
	Canvas canvas;
	CameraController cameraController;

	void Start () {
		canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
		cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
	}

	void Update () {
	
	}

	//Gameoverになった時の表示
	public void Gameover(){
		gameovertext.text = "廃棄";
		canvas.enabled = true;
		cameraController.SetGameOver();
	}

	//Goalした時の表示
	public void Goal(){
		gameovertext.text = "購入";
		canvas.enabled = true;
	}

	//リトライを押した時の画面遷移
	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	//タイトルを押した時の画面遷移
	public void BackTitke()
	{
		SceneManager.LoadScene("Title");
	}
}