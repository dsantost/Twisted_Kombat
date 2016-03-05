using UnityEngine;
using System.Collections;

public class ButtonCatcherBehaviour : MonoBehaviour {

    public Camera cam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(70, 60, 5));
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            if(!other.gameObject.GetComponent<ButtonComandBehaviour>().pressed)
            {
                // damage
            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow" && !other.gameObject.GetComponent<ButtonComandBehaviour>().pressed)
        {
            switch (other.gameObject.GetComponent<ButtonComandBehaviour>().spriteToDraw) {
                case TypeOfSprite.Up:
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        other.gameObject.GetComponent<ButtonComandBehaviour>().pressed = true;
                        other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
                        // give points
                    }
                    break;
                case TypeOfSprite.Down:
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        other.gameObject.GetComponent<ButtonComandBehaviour>().pressed = true;
                        other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
                        // give points
                    }
                    break;
                case TypeOfSprite.Left:
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        other.gameObject.GetComponent<ButtonComandBehaviour>().pressed = true;
                        other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
                        // give points
                    }
                    break;
                case TypeOfSprite.Right:
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        other.gameObject.GetComponent<ButtonComandBehaviour>().pressed = true;
                        other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
                        // give points
                    }
                    break;
            }
        }
    }
}
