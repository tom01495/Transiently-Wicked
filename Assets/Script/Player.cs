using System.Collections.Generic;

public class Player {

    private List<Card> deck = new List<Card> { new Card(), new Card() };

    public List<Card> getHand() { // een functie die een hoeveelheid kaarten uit het deck haalt. voor nu...
        return deck;
    }

    public void setDeck(List<Card> deck) { // een tijdelijke verschrikkelijke functie
        this.deck = deck;
    }
}
