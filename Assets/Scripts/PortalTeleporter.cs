using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{

    public PortalTeleporter portalOther;
    public float cooldown;
    public GameObject portalOtherGhost;


    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= 1f * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
                
        if (cooldown! > 0)
        {
            return;
        }

        collision.transform.position = portalOtherGhost.transform.position;
        portalOther.cooldown = 0.1f;
        cooldown = 0.1f;
    }
}
