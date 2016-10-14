using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {

	GoalTriggerSlave goalSlave;

	void Start () {
		goalSlave = GetComponentInChildren<GoalTriggerSlave>();
	}

	void OnTriggerEnter (Collider collider) {
		print ("new "+collider);
		goalSlave.ExpectCollider (collider);
		print ("new after adding "+collider);
	}
}
