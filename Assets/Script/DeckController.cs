using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour {

    public GameObject playerObject;

    private void Start() {
        if(playerObject!=null) {
            Player player = playerObject.GetComponent<PlayerComponent>().player;

            List<Card> deck = new List<Card> { new Card(), new Card(), new Card() };
            player.setDeck(deck);
        }
    }
}
