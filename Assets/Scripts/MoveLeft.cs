using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	public float Speed = 1f;

    void Update()
    {
		transform.position += new Vector3(-Speed, 0f, 0f) * Time.deltaTime;
    }
}
