using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Action_Rock : MonoBehaviour {

    public int currentTurn;
    GameObject lp1t;
    GameObject lp2t;

    void Start () {
        lp1t = GameObject.Find("Label_p1t");
        lp2t = GameObject.Find("Label_p2t");
    }
	
	void Update () {}

    private void OnMouseDown()
    {
        Debug.Log("clicked: " + this.transform.parent.GetComponent<ObjectScript>().currentTurn);
        currentTurn = this.transform.parent.GetComponent<ObjectScript>().currentTurn;
        if (currentTurn == 1)
        {
            lp1t.transform.position = new Vector3(100, 16, -0.1f);
            lp2t.transform.position = new Vector3(0, 16, -0.1f);
            this.transform.parent.GetComponent<ObjectScript>().player1Action = 1;
            this.transform.parent.GetComponent<ObjectScript>().currentTurn = 2;
        } else if (currentTurn == 2) {
            this.transform.parent.GetComponent<ObjectScript>().player2Action = 1;
        }
    }
}
