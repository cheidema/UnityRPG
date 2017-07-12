using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Begin : MonoBehaviour {
	GameObject newGame;
	GameObject continueGame;
	GameMode myGameMode;
	ControlMode myControlMode;
	int menu;
	// Use this for initialization
	void Start () {
		myGameMode = GameMode.TitleScreen;
		myControlMode = ControlMode.Nothing;
		menu = 0;
	}
	   bool GUIKeyDown(KeyCode key)
    {
        if (Event.current.type == EventType.KeyDown)
            return (Event.current.keyCode == key);
        return false;
    }
	// Update is called once per frame
	void Update()
	{
		if (myControlMode == ControlMode.Nothing){
			if (Input.GetKeyDown(KeyCode.W))
   			{
   				menu = 1;
        	}
        	if (Input.GetKeyDown(KeyCode.S)){
        		menu = 0;
        	}
        	if (menu == 1 && Input.GetKeyDown(KeyCode.Space)){
        		myControlMode = ControlMode.Walk;
        	}
        	if (menu == 0 && Input.GetKeyDown(KeyCode.Space)){
        		myControlMode = ControlMode.MiniGame;
        	}
		}
		if (myControlMode == ControlMode.Nothing){
			newGame = new GameObject("Load Game Select");
		    SpriteRenderer renderer = newGame.AddComponent<SpriteRenderer>();
		    if (menu == 1){
					renderer.sprite = Resources.Load<Sprite>("battleAttack");
		    }
		    else if (menu == 0){
	        		renderer.sprite = Resources.Load<Sprite>("battleDefend");
		    }
		    newGame.transform.localScale = new Vector2(10,10);
		    newGame.transform.localEulerAngles = new Vector3(0,0,10 *(float)System.Math.Sin(Time.realtimeSinceStartup*10));
			Destroy(newGame,0.02f);
		}
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
