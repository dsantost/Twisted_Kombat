using UnityEngine;
using System.Collections;

public class ScrollingText : MonoBehaviour {
	private GameObject introText;

	// Use this for initialization
	void Start () {
		introText = GameObject.FindGameObjectWithTag ("ScrollingText");
	}
	
	// Update is called once per frame
	void Update () {

		introText.transform.position = new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z);
		//introText.transform.localPosition.y += 1 * Time.deltaTime;
	}
}
