using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDistance : MonoBehaviour
{
    public List<Collider2D> colliders = new List<Collider2D>();
    public List<Collider2D> GetCollider() { return colliders; }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (!colliders.Contains(collision))
        {
            if(collision.tag.ToLower().Contains("turtle"))
            {
                print("entrou");
                colliders.Add(collision);
            }
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        colliders.Remove(collision);
    }

    public void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            for (int i = 0; i < colliders.Count; i++)
            {
                Destroy(colliders[i].gameObject);
            }
        }
    }
}
