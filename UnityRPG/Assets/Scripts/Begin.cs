using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Begin : MonoBehaviour {
	GameObject newGame;
	GameObject continueGame;
	// Use this for initialization
	void Start () {
		GameMode myGameMode = GameMode.TitleScreen;
		ControlMode myControlMode = ControlMode.LoadNew;
	}
	// Update is called once per frame
	void FixedUpdate()
	{
		newGame = new GameObject("Load Game Select");
	    SpriteRenderer renderer = newGame.AddComponent<SpriteRenderer>();
	    if (Time.realtimeSinceStartup > 5){
			renderer.sprite = Resources.Load<Sprite>("battleDefend");
	    }
	    else{
			renderer.sprite = Resources.Load<Sprite>("battleAttack");
	    }
	    newGame.transform.localScale = new Vector2(10,10);
	    newGame.transform.localEulerAngles = new Vector3(0,0,10 *(float)System.Math.Sin(Time.realtimeSinceStartup*10));
		Destroy(newGame,0.02f);
	}

	void RunGame(GameMode myGameMode, ControlMode myControlMode){
		if (myControlMode == ControlMode.Nothing) {

		}
		else if (myControlMode == ControlMode.LoadNew){

		}

		if (myGameMode == GameMode.Intro){
			Screen myscreen = new Screen();
			myscreen.run ();
		}
		else if (myGameMode == GameMode.TitleScreen){

		}
	}
}
