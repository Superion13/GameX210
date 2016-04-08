using UnityEngine;
using System.Collections;

public class des : MonoBehaviour{
	public GameObject explosion;
	
	void OnTriggerExit(Collider Other)
	{
		if (Other.tag == "w") {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy(Other.gameObject);
		Destroy (gameObject);
	}
}
