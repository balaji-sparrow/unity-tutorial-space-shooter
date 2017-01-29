using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
//		if (other.CompareTag("Boundary")) {
		if (other.tag == "Boundary") {
			// Ignore Boundary
			return;
		}

		Destroy(other.gameObject); // Bolt
		Destroy(gameObject); // Asteroid
	}
}
