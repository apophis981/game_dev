using UnityEngine;
using System.Collections;

public class bad_button : MonoBehaviour {

	public lose_screen _lose_screen;
	public Sprite button_up;
	public Sprite button_down;

	private SpriteRenderer spriteRenderer; 

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = button_up; // set the sprite to sprite1
	}

	void OnMouseUp() {
		spriteRenderer.sprite = button_up;
		_lose_screen.show_lose();
		//Display win message
	}

	void OnMouseDown() {
		spriteRenderer.sprite = button_down;
	}

	// Update is called once per frame
	void Update () {
	
	}
}