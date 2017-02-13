using UnityEngine;
using System.Collections;

public class WeightController : MonoBehaviour {
    private float positionx;
    private float positiony;
    public float mass;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
        mass = 

        positionx = Input.mousePosition.x;
        positiony = Input.mousePosition.y;

    }

    void OnMouseDrag()
    {
        Vector3 mouseposition = new Vector3(positionx, positiony,20.0f);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mouseposition);
        transform.position = new Vector3(0, transform.position.y, transform.position.z);

        transform.position = objPosition;
    }
}
