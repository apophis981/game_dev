using UnityEngine;
using System.Collections;

public class good_button_script : MonoBehaviour {

	public bool show_win_screen;
	public win_screen _win_screen;

	void OnMouseUp() {
		_win_screen.show_win();
		show_win_screen = true;
		//Display win message
	}

	// Use this for initialization
	void Start () {
		show_win_screen = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
