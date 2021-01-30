using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    public BoxCollider2D bc;

    void enableCollider()
    {
        bc.enabled = false;
        bc.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        switch(coll.gameObject.name)
        {
            case "rock_small":
                bc.sharedMaterial.bounciness = 0.3f;
                enableCollider();
                break;
            case "rock_medium":
                bc.sharedMaterial.bounciness = 0.5f;
                enableCollider();
                break;
            case "rock_big":
                bc.sharedMaterial.bounciness = 0.7f;
                enableCollider();
                break;
        }
    }

}
