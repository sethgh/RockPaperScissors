using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour {

    public int currentTurn;
    public int player1Action;
    public int player2Action;
    public int playAgain;

    GameObject ltie;
    GameObject rock;
    GameObject paper;
    GameObject scissors;

    void Start () {
        transform.GetChild(3).gameObject.transform.position = new Vector3(0, 16, -0.1f);
        currentTurn = 1;
        player1Action = 0;
        player2Action = 0;
        playAgain = 0;
        rock = GameObject.Find("Action_Rock");
        paper = GameObject.Find("Action_Paper");
        scissors = GameObject.Find("Action_Scissors");
    }
	
	void Update () {

        if ((player1Action!=0)&&(player2Action!=0))
        {
            switch(player1Action)
            {
                case 1:
                    switch(player2Action)
                    {
                        case 1:
                            Debug.Log("rock rock tie");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(8).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 2:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("rock paper p2 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(7).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 3:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("rock scissors p1 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(6).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (player2Action)
                    {
                        case 1:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("paper rock p1 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(6).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 2:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("paper paper tie");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(8).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 3:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("paper scissors p2 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(7).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (player2Action)
                    {
                        case 1:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("scissors rock p2 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(7).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 2:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("scissors paper p1 win");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(6).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        case 3:
                            rock.SetActive(false);
                            paper.SetActive(false);
                            scissors.SetActive(false);
                            Debug.Log("scissors scissors tie");
                            transform.GetChild(3).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
                            transform.GetChild(5).gameObject.transform.position = new Vector3(0, 11, -0.1f);
                            transform.GetChild(8).gameObject.transform.position = new Vector3(0, 13.6f, -0.1f);
                            player1Action = 0;
                            player2Action = 0;
                            currentTurn = 3;
                            break;
                        default:
                            break;
                    }
                    break;
            }
        } else if (currentTurn==3)
        {
            if (playAgain==1)
            {
                player1Action = 0;
                player2Action = 0;
                currentTurn = 1;
            }
        }

	}

    public void newGame()
    {
        rock.SetActive(true);
        paper.SetActive(true);
        scissors.SetActive(true);
        transform.GetChild(3).gameObject.transform.position = new Vector3(0, 16, -0.1f);
        transform.GetChild(4).gameObject.transform.position = new Vector3(100, 16, -0.1f);
        transform.GetChild(5).gameObject.transform.position = new Vector3(100, 11, -0.1f);
        transform.GetChild(6).gameObject.transform.position = new Vector3(100, 13.6f, -0.1f);
        transform.GetChild(7).gameObject.transform.position = new Vector3(100, 13.6f, -0.1f);
        transform.GetChild(8).gameObject.transform.position = new Vector3(100, 13.6f, -0.1f);
        currentTurn = 1;
    }
}
