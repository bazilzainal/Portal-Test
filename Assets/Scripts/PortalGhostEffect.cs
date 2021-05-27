using UnityEngine;

public class PortalGhostEffect : MonoBehaviour
{

    public SpriteRenderer ghost;
    public PortalTeleporter thisPortal;

    //Start the ghost effect when entering the portal
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Triggered!");

        var offset = collision.transform.position - transform.position;

        ghost.transform.position = thisPortal.portalOther.transform.position + offset;

        ghost.gameObject.SetActive(true);
    }

    //Disable the ghost effect when leaving the portal
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Left!");
        ghost.gameObject.SetActive(false);
    }
}
