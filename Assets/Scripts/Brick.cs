using UnityEngine;
using System.Collections;



public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;







		// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timesHit >= maxHits) {
			Destroy (gameObject); 
		}

	}
	void OnCollisionEnter2D(Collision2D coll) {
		timesHit ++;
		print ("I've been hit " + timesHit + " times!!");

	}
   

}
