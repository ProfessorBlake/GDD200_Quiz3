using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float MoveSpeed = 1f;

	private void Update()
	{
		transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + (Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed), -4f, 4f), 0f);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Time.timeScale = 0f;
		Destroy(gameObject);
	}
}
