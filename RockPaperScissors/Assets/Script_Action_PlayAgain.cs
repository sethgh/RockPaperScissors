using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Action_PlayAgain : MonoBehaviour {

    GameObject rock;
    GameObject paper;
    GameObject scissors;

    void Start () {
        rock = GameObject.Find("Action_Rock");
        paper = GameObject.Find("Action_Paper");
        scissors = GameObject.Find("Action_Scissors");
    }
	
	void Update () {}

    private void OnMouseDown()
    {
        ObjectScript foo = transform.parent.GetComponent<ObjectScript>();
        foo.newGame();
    }
}
