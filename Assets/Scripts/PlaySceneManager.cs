using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySceneManager : MonoBehaviour
{
	void Start ()
	{
		count_down_val = 3;
		count_down.text = count_down_val.ToString();
		obj_floor = GameObject.Find("Floor");
		obj_character = GameObject.Find("Character");
	}

	void Update ()
	{
		oneSecondProcess();
		
		// カウントダウンが完了していない場合は処理を終了する
		if (-1 < count_down_val) return;

		moveFloor();
		runCharacter();
	}



	// 1秒ごとの処理を行う
	private float one_second_count;
	void oneSecondProcess()
	{
		// 1秒経過していなければ処理終了
		if (1.0f > one_second_count) {
			one_second_count += Time.deltaTime;
			return;
		}
		one_second_count = 0.0f;

		// カウントダウンが0以上の場合、カウントダウンを進める
		if (0 <= count_down_val) countDownForGameStart();
		// また、カウントダウンが0未満となっていない場合、以降の処理を行わない
		if (-1 < count_down_val) return;
	}

	// スタートまでのカウントダウン
	public Text count_down;
	private int count_down_val;
	void countDownForGameStart()
	{
		count_down_val--;
		if (0 == count_down_val) {
			count_down.text = "GO";
		} else if (-1 == count_down_val) {
			count_down.text = "";
		} else {
			count_down.text = count_down_val.ToString();
		}
	}

	// 床を動かす
	GameObject obj_floor;
	void moveFloor()
	{
		Floor floor = obj_floor.GetComponent<Floor>();
		floor.move();
	}

	// キャラクターを走らせる
	GameObject obj_character;
	void runCharacter()
	{
		Character chara = obj_character.GetComponent<Character>();
		chara.startRunning();
	}
}
