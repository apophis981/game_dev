using UnityEngine;
using System.Collections;

public class win_script : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject good_button = GameObject.Find("good_button");
		good_button_script script = good_button.GetComponent<good_button_script>();
		if (script.show_win_screen == true){
			Debug.Log ("You did it");
			gameObject.SetActive(true);
		}
	
	}
}
