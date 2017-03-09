using UnityEngine;
using System.Collections;

public class CommandCenter : MonoBehaviour, IBuilding {

    public int Health;
    public GameObject Worker;

    private Worker worker;

    public void CreateWorker()
    {
        worker = Worker.GetComponent<Worker>();
        StartCoroutine(BuildUnit(Worker, worker.BuildTime));
    }

    public IEnumerator BuildUnit(GameObject unit, float buildTime)
    {
        yield return new WaitForSeconds(buildTime);
        Instantiate(Worker, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5), transform.rotation);
        Debug.Log("hello " + unit.name);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
