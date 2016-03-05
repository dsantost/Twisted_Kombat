using UnityEngine;
using System.Collections;

// Do not change the order
public enum TypeOfSprite { Up, Right, Left, Down };

public class ButtonComandBehaviour : MonoBehaviour {

    public TypeOfSprite spriteToDraw = TypeOfSprite.Up;
    public Sprite[] sprites = new Sprite[4];
    public float speed = 1f;
    public bool pressed = false;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = sprites[(int)spriteToDraw];
	}
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void UpdateSpriteToDraw()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[(int)spriteToDraw];
    }

    public void SetSpriteToRender(char letter)
    {
        switch (letter)
        {
            case 'U':
                spriteToDraw = TypeOfSprite.Up;
                break;
            case 'D':
                spriteToDraw = TypeOfSprite.Down;
                break;
            case 'L':
                spriteToDraw = TypeOfSprite.Left;
                break;
            case 'R':
                spriteToDraw = TypeOfSprite.Right;
                break;
            default:
                break;
        }
        UpdateSpriteToDraw();
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
