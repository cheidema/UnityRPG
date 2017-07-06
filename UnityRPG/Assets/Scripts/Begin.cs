using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour {
     public Sprite sprite;

	// Use this for initialization
	void Start () {
         GameObject go = new GameObject("Load Game Select");
         SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
         sprite = Resources.Load<Sprite>("battleAttack");
         renderer.sprite = sprite;
	}
	
	// Update is called once per frame
 void Update()
 {

 }
}
