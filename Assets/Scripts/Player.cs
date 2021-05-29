using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public float speed = 5.0f;
	public float slideSpped = 2.0f;

	//アニメーション
	Animator animator;
	//UIを管理するスクリプト
	UIManager uiscript;

	Rigidbody rig;


	void Start()
	{
		//変数に必要なデータを格納
		animator = GetComponent<Animator>();
		uiscript = GameObject.Find("Canvas").GetComponent<UIManager>();
		rig = GetComponent<Rigidbody>();
	}



	void Update()
	{
		//前に進む
		transform.position += new Vector3(0, 0, speed) * Time.deltaTime;

		//現在のX軸の位置を取得
		float pos_x = transform.position.x;

		//右アローキーを押した時
		if (Input.GetKey(KeyCode.RightArrow))
        {
			if (pos_x < 2.0f)
            {
				transform.position += new Vector3(slideSpped, 0, 0) * Time.deltaTime;
            }
        }

		if (Input.GetKey(KeyCode.LeftArrow))
        {
			if (pos_x > -2.0f)
            {
				transform.position -= new Vector3(slideSpped, 0, 0) * Time.deltaTime;
            }
        }

		//左アローキーを押した時


		//アニメーション
	

		//現在再生されているアニメーション情報を取得
		var stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		//取得したアニメーションの名前が一致指定ればtrue
		bool isJump = stateInfo.IsName("Base Layer.Jump");
		bool isSlide = stateInfo.IsName("Base Layer.Slide");

		//ジャンプ


		//スライディングしていたら頭の判定をなくす
		

		//落下時のGameOver判定
		

	}

	// Triggerである障害物にぶつかったとき
	void OnTriggerEnter(Collider colider)
	{
		//ゴールした時
		if (colider.gameObject.tag == "Goal")
		{
			//速度を0にして進むのを止める
			speed = 0;

			//横移動する速度を0にして左右移動できなくする
			slideSpped = 0;

			//ゴールをしたら正面を向くようにする
			Vector3 lockpos = Camera.main.transform.position;
			lockpos.y = transform.position.y;
			transform.LookAt(lockpos);

			//アニメーション
			animator.SetBool("Win", true);

			//UIの表示
			uiscript.Goal();
			
		}
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DustBox")
        {
			animator.SetBool("Dead", true);
			uiscript.Gameover();

			speed = 0;
			slideSpped = 0;
        }
    }


    //Triggerでない障害物にぶつかったとき

}
