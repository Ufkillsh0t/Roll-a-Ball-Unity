using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        //ctrl+alt+m +ctrl+h voor shortcut naar api
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
