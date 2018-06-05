using UnityEngine;



public class Rotator : MonoBehaviour 
{


	#region Private Unity properties

	[SerializeField] private Vector3 eulerAngles;
	
	#endregion
	


	private void Update () 
	{
		transform.Rotate(eulerAngles);
	}



}
