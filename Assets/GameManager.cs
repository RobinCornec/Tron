using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private int[] score;
    public int numberOfPlayers = 2;
	// Use this for initialization
	void Start()
    {
        score = new int[numberOfPlayers];
        for (int i = 1; i < numberOfPlayers; i++)
        {
            score[i] = 0;
        }
	}
	
	// Update is called once per frame
	void Update() {
	}

    public void updateScore(GameObject looser) {
        Debug.Log(looser);
    }
}
