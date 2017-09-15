using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hier worden alle essentiele onderdelen voor het beginnen van een spel geladen
public class MainController : MonoBehaviour {

    public GameObject playerOneObject;
    public GameObject playerTwoObject;
    public GameObject cardPrefab;
    private List<GameObject> cardList = new List<GameObject>();

	// Use this for initialization
	void Start () {
        int i = 0;

        if(playerOneObject!=null) {
            Player playerOne = playerOneObject.GetComponent<PlayerComponent>().player;

            foreach (Card c in playerOne.getHand()) {
                GameObject obj = (GameObject)Instantiate(cardPrefab, new Vector3(i, -1, 0), Quaternion.identity);
                obj.name = "Card_1_" + i;
                obj.GetComponent<CardComponent>().c = c;

                cardList.Add(obj);
                i++;
            }
        }

        i = 0;
        if (playerTwoObject!=null) {
            Player playerTwo = playerTwoObject.GetComponent<PlayerComponent>().player;

            foreach (Card c in playerTwo.getHand()) {
                GameObject obj = (GameObject)Instantiate(cardPrefab, new Vector3(i, 1, 0), Quaternion.identity);
                obj.name = "Card_2_" + i;
                obj.GetComponent<CardComponent>().c = c;

                cardList.Add(obj);
                i++;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
