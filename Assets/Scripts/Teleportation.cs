using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject targetarea;
    void onTriggerEnter(Collider col)
    {
        Debug.Log("Trigger");
        Vector3 target = new Vector3(targetarea.transform.position.x, col.transform.position.y, targetarea.transform.position.z);
        col.transform.localPosition = target; // teleport to targetarea
    }
}
