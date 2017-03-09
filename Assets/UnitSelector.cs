using UnityEngine;
using System.Collections;

public class UnitSelector : MonoBehaviour {

    public GameObject CommandCenterMenu;
    public GameObject WorkerMenu;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name != "Floor")
                {
                    CommandCenterMenu.SetActive(false);
                    WorkerMenu.SetActive(false);
                    StartCoroutine(Scale(hit.transform));
                }
                if (hit.transform.name == "CommandCenter")
                {
                    CommandCenterMenu.SetActive(true);
                }
                if (hit.transform.name.Contains("Worker"))
                {
                    WorkerMenu.SetActive(true);              
                }
            }            
        }
        
    }

    IEnumerator Scale(Transform obj)
    {
        obj.localScale *= 1.2f;
        yield return new WaitForSeconds(.05f);
        obj.localScale /= 1.2f;
    }
}
