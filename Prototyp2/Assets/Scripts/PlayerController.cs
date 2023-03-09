using UnityEngine;

public class PlayerController:MonoBehaviour {


	[SerializeField] private float horizontallInput;
	[SerializeField] private float speed = 30.0f;
	[SerializeField] private GameObject projectilePrefab;
	private float xBounds = 20.0f;


	// Start is called before the first frame update
	void Start() {

	}


	// Update is called once per frame
	void Update() {
		// the if statments keep the player in bounds on x axis
		if(transform.position.x<-xBounds) {
			transform.position=new Vector3(-xBounds, transform.position.y, transform.position.z);
		}
		if(transform.position.x>xBounds) {
			transform.position=new Vector3(xBounds, transform.position.y, transform.position.z);
		}

		horizontallInput=Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right*horizontallInput*speed*Time.deltaTime);

		if(Input.GetKeyUp(KeyCode.Space)) {

			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}

	}

}
