using UnityEngine;

public class DestroyWhenOutOfBounds:MonoBehaviour {

	private float topBoundry = 14.0f;
	private float bottomBounddry = -15.0f;

	// Start is called before the first frame update
	void Start() {

	}


	// Update is called once per frame
	void Update() {

		if(transform.position.z>topBoundry) {
			Destroy(gameObject);
		}
		else if(transform.position.z<bottomBounddry) {
			Destroy(gameObject);
			Debug.Log(" GAME OVER! ");
		}
	}

}













