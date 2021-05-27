using UnityEngine;

public class PortalGhostEffect : MonoBehaviour
{

    public SpriteRenderer ghost;
    public PortalTeleporter thisPortal;
    bool enterPortal = false;
    Collider2D currentPortal;
    Vector3 offset;

    private void Update()
    {
        if (enterPortal)
        {
            GhostApparate();
        }
    }

    void GhostApparate()
    {
        offset = currentPortal.transform.position - transform.position;

        ghost.transform.position = thisPortal.portalOther.transform.position + offset;

        ghost.gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered!");
        enterPortal = true;
        currentPortal = collision;
        
    }
    //Disable the ghost effect when leaving the portal
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Left!");
        ghost.gameObject.SetActive(false);
        enterPortal = false;
    }
}
