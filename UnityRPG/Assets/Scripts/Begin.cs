using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour {
    public Sprite sprite;
    GameObject go;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		go = new GameObject("Load Game Select");
	    SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();

	    renderer.sprite = sprite;
	    if (Time.realtimeSinceStartup > 5){
	    	sprite = Resources.Load<Sprite>("battleDefend");
	    }
	    else{
	    	sprite = Resources.Load<Sprite>("battleAttack");
	    }
	    go.transform.localScale = new Vector2(10,10);
	    go.transform.localEulerAngles = new Vector3(0,0,10 *(float)System.Math.Sin(Time.realtimeSinceStartup*10));
	    renderer.sprite = sprite;
		Destroy(go,0.02f);
	}
}
