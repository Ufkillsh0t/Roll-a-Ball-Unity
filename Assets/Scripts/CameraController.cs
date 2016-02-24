using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Updates once all the updates have been performed, so we know the player object has moved.
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
