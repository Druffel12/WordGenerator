using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerMovement : MonoBehaviour
{ 
    private AudioSource whyAmIDoingThis1;

    private Transform target;

    private int wavepointIndex = 0;

    public int speed;

	// Use this for initialization
	void Start ()
    {
        target = Waypoints.waypoints[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
	}

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.waypoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoints.waypoints[wavepointIndex];
    }

    void EndPath()
    {
        wavepointIndex = 0;
        target = Waypoints.waypoints[0];
        //whyAmIDoingThis1.Play();
    }
}
