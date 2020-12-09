using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{

	public int XRotation;
	public int YRotation;
	public int ZRotation;

	void Update () 
	{
		transform.Rotate (new Vector3 (XRotation, YRotation, ZRotation) * Time.deltaTime);
	}
}
