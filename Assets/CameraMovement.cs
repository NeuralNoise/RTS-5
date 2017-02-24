using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public int Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition);
        }
        // X axis
        if (Input.mousePosition.x < 10)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * Speed));
        }
        if (Input.mousePosition.x > Screen.width - 10)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * Speed));
        }
        // Y axis
        if (Input.mousePosition.y < 10)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * Speed));
        }
        if (Input.mousePosition.y > Screen.height - 10)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * Speed));
        }
	
	}
}
