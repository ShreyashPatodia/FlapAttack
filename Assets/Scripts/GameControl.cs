﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;

	public Text scoreText;
	public bool gameOver = false;

	public float scrollSpeed = -1.5f;

	private int score = 0;

	public const int LEFT = 0;
	// Use this for initialization

	// To make sure the generation is done
	void Awake() {

		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if(gameOver && Input.GetMouseButtonDown(LEFT))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		
	}

	public void BirdDied()
	{
		gameOverText.SetActive(true);
		gameOver = true;
		return;

	}

	public void BirdScored() {
		if(gameOver)
		{
			return;
		}

		score++;

		scoreText.text = "Score: " + score.ToString();
		return;

	}
}
