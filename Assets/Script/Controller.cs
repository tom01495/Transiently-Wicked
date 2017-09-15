using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    public GameObject cardPrefab;
    private List<GameObject> cardList = new List<GameObject>();

	// Use this for initialization
	void Start () {
        for(int i=0; i<3; i++)
        {
            Card c = new Card();

            GameObject obj = (GameObject) Instantiate(cardPrefab, new Vector3(i,0,0), Quaternion.identity);
            obj.name = "Card_" + i;
            obj.GetComponent<CardComponent>().c = c;
        
            cardList.Add(obj);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
