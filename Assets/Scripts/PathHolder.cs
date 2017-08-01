using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathHolder : MonoBehaviour {

    public Vector3[] returnWaypoints()
    {
        Vector3[] waypoints = new Vector3[this.transform.childCount];
        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = this.transform.GetChild(i).position;
            waypoints[i] = new Vector3(waypoints[i].x, waypoints[i].y, waypoints[i].z);
        }
        return waypoints;
    }

    void OnDrawGizmos()
    {
        Vector3 startPosition = this.transform.GetChild(0).transform.position;
		Vector3 previousPosition = startPosition;

		for (int i = 0; i < this.transform.childCount; i++)
		{
            Transform waypoint = this.transform.GetChild(i).transform;
            Gizmos.DrawSphere(waypoint.position, .3f);
            Gizmos.DrawLine(previousPosition, waypoint.position);
            previousPosition = waypoint.position;
		}		
		Gizmos.DrawLine (previousPosition, startPosition);
	}
}
