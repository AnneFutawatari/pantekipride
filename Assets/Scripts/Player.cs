using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    bool running;
	float speed;
	private float count;
	public float playerSpeed = 10.0f;
	public float slideSpeed = 10.0f;
	public int jumpCount = 1;
	int defaultJumpCount;

	//アニメーション
	Animator animator;
	//UIを管理するスクリプト
	UIManager uiscript;

	Rigidbody rig;

    void Start()
	{
		running = true;

		//変数に必要なデータを格納
		animator = GetComponent<Animator>();
		uiscript = GameObject.Find("Canvas").GetComponent<UIManager>();
		rig = GetComponent<Rigidbody>();

		defaultJumpCount = jumpCount;
	}

	void Update()
	{
		//前に進む
		transform.position += new Vector3(0, 0, playerSpeed) * Time.deltaTime;

		//現在のX軸の位置を取得
		float pos_x = transform.position.x;

		//右アローキーを押した時
		if (Input.GetKey(KeyCode.RightArrow))
        {
			if (pos_x < 5.0f)
            {
				transform.position += new Vector3(slideSpeed, 0, 0) * Time.deltaTime;
            }
        }

		//左アローキーを押した時
		if (Input.GetKey(KeyCode.LeftArrow))
        {
			if (pos_x > -5.0f)
            {
				transform.position -= new Vector3(slideSpeed, 0, 0) * Time.deltaTime;
            }
        }

		//現在再生されているアニメーション情報を取得
		//var stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		//取得したアニメーションの名前が一致指定ればtrue
		//bool isJump = stateInfo.IsName("Base Layer.Jump");
		//bool isSlide = stateInfo.IsName("Base Layer.Slide");

		//ジャンプ
		if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount > 0)
        {
	

			rig.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);

			//animator.SetTrigger("Jump");

			jumpCount--;
        }
	}

	//スピードを戻す
	//void SpeedModosu()
    //{
		//speed = playerSpeed;
    //}

	// Triggerである障害物にぶつかったとき
	void OnTriggerEnter(Collider colider)
	{
		//ゴールした時
		if (colider.gameObject.tag == "Goal")
		{
			//速度を0にして進むのを止める
			playerSpeed = 0;

			//横移動する速度を0にして左右移動できなくする
			slideSpeed = 0;

			//ゴールをしたら正面を向くようにする
			Vector3 lockpos = Camera.main.transform.position;
			lockpos.y = transform.position.y;
			transform.LookAt(lockpos);

			//アニメーション
			//animator.SetBool("Win", true);

			//UIの表示
			uiscript.Goal();
			
		}
	}

	//DustBoxに当たったら止まる
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DustBox")
        {
			playerSpeed = 0;
			slideSpeed = 0;

			animator.SetBool("Dead", true);
			uiscript.Gameover();
        }

		//ジャンプの数
		if (collision.gameObject.tag == "Ground")
        {
			jumpCount = defaultJumpCount;
        }
    }
}
