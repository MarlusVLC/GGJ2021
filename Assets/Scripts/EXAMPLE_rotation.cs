using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using ExtensionMethods;

public class launchArrow : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float distFromRef;
    [SerializeField] private Transform launchRef;
    public static float pointerAngle;


    private void Start()
    {
        //launchRef = GetComponent<GameObject>();
        //launchRef = GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // pointerAngle = gameManager.Instance.nonNegLaunchingAngle();
        Quaternion rotation = Quaternion.AngleAxis(pointerAngle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed);

        float arrowX = launchRef.position.x +  Mathf.Cos(pointerAngle * Mathf.Deg2Rad) * distFromRef;
        float arrowY = launchRef.position.y +  Mathf.Sin(pointerAngle * Mathf.Deg2Rad) * distFromRef;
        transform.position = new Vector3(arrowX, arrowY, -0.5f);
    }
}
