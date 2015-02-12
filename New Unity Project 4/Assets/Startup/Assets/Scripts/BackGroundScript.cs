using UnityEngine;
using System.Collections;

public class BackGroundScript : MonoBehaviour {

	public float speed = 0;
	public static BackGroundScript current;

	float pos = 0;
	// Use this for initialization
	void Start () {
		current = this;
		if (Application.loadedLevelName == "options") {

				}
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "options") {
						
								pos += speed;
								if (pos > 1.0f)
										pos -= 1.0f;

								renderer.material.mainTextureOffset = new Vector2 (pos, 0);
						
				} else {
						pos += speed;
						if (pos > 1.0f)
								pos -= 1.0f;
			
						renderer.material.mainTextureOffset = new Vector2 (pos, 0);
				}
	}
}
