using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class ButtonListBehaviour : MonoBehaviour {

    public Camera cam;
    public ButtonComandBehaviour prefab;
    public string buttonList = "";
    private char[] buttonListArray;
    public float timeBetweenButtons = 5.0f;
    private float lastTime;

	// Use this for initialization
	void Start () {
        lastTime = UnityEngine.Time.time;
        buttonList = Regex.Replace(buttonList, @"\s+", "");
        buttonListArray = buttonList.ToCharArray();
    }
	
	// Update is called once per frame
	void Update () {
        float now = UnityEngine.Time.time;
        if (now - lastTime >= timeBetweenButtons)
        {
            lastTime = now;
            SendComandScreen();
        }
	}

    void InitArray()
    {
        buttonList = Regex.Replace(buttonList, @"\s+", "");
        buttonListArray = buttonList.ToCharArray();
    }

    void SendComandScreen()
    {
        if(buttonListArray.Length > 0) { 
            ButtonComandBehaviour obj = Instantiate(prefab);
            obj.SetSpriteToRender(buttonListArray[0]);
            obj.transform.position = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth - 25, 60, 5));
            buttonListArray = new string(buttonListArray).Remove(0, 1).ToCharArray();
        }
    }
}
