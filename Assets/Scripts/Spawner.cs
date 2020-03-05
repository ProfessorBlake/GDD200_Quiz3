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
			GameObject ball = Instantiate(EnemyPrefabArray[Random.Range(0,EnemyPrefabArray.Length)], transform.position, Quaternion.identity);
			ball.transform.position += new Vector3(0f, Random.Range(-4f, 4f), 0f);
			Score.Points += 1;
			ScoreText.text = "Score: " + Score.Points;
		}
	}
}
