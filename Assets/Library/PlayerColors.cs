using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Player { NONE, One, Two }
public class PlayerColors : MonoBehaviour {
    public Color playerOneColor;
    public Color playerTwoColor;
    public Color playerOneColorHighlighted;
    public Color playerTwoColorHighlighted;

    public static PlayerColors instance;

    private void Awake() {
        instance = this;
    }

    public Color GetPlayerColor(Player player, bool highlight) {
        if (highlight) {
            if (player == Player.One)
                return playerOneColorHighlighted;
            if (player == Player.Two)
                return playerTwoColorHighlighted;
        }
        else {
            if (player == Player.One)
                return playerOneColor;
            if (player == Player.Two)
                return playerTwoColor;
            Debug.Log("Color funktioniert");
        }
        return Color.magenta;
    }
}
