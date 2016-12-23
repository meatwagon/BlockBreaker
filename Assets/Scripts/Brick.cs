using UnityEngine;
using System.Collections;



public class Brick : MonoBehaviour {


	private int timesHit;
	private LevelManager levelManager;
	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	private bool isBreakable; 






		// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "breakable");
		if (isBreakable) {
			breakableCount++;
			print (breakableCount);
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {


	}
	void OnCollisionEnter2D(Collision2D coll) {

		if (isBreakable) {
			HandleHits();
		}
	}
	void HandleHits () {
		timesHit ++;
		int maxHits = hitSprites.Length + 1;
		print ("I've been hit " + timesHit + " times!!");
		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy (gameObject); 
		} else { 
			LoadSprites();
		}

	}

	void LoadSprites (){
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		}
	}

}
