using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
	public GameObject[] EnemyPrefabArray;
	public Text ScoreText;

	private float spawnDelay = 1f;

	private void Update()
	{
		spawnDelay -= Time.deltaTime;
		if(spawnDelay <= 0f)
		{
			spawnDelay = 1f;

			//Add instantiating code here.

			ScoreText.text = "Score: " + Score.Points;
		}
	}
}
