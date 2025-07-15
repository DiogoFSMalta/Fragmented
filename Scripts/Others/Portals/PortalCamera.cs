using UnityEngine;

public class PortalCamera : MonoBehaviour
{
	public Transform playerCamera;
	public Transform portal;
	public Transform otherPortal;

	// Update is called once per frame
	void LateUpdate()
	{
		Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
		this.transform.position = portal.position + playerOffsetFromPortal;

		float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

		Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
		Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
		this.transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
	}

}
