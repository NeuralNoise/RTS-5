using UnityEngine;
using System.Collections;

public class UnitSelector : MonoBehaviour {

    public GameObject CommandCenterMenu;
    private bool commandMenuVisable = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            commandMenuVisable = !commandMenuVisable;
            CommandCenterMenu.SetActive(commandMenuVisable);
        }
	}
}
