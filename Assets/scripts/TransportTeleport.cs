using UnityEngine;
using Unity.XR.CoreUtils;

public class TransportTeleport : MonoBehaviour {
    
    public Transform teleportDestination;
    public XROrigin xrOrigin;
    public GameObject popupPanel;

    public void OnTeleportClick()
    {
        if(xrOrigin != null && teleportDestination != null)
            xrOrigin.MoveCameraToWorldLocation(teleportDestination.transform.position);
            Debug.Log("Teleported XR Rig to " + teleportDestination.position);
    }
    public void onStayClick()
    {
        if(popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
    }




}