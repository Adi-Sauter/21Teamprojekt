using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    // public Vector3 offset;
    // public Transform player;
 
 
    //  void Update()
    //  {
    //      Vector3 position = transform.position;
    //      position.y = (player.position + offset).y;
    //      position.x = (player.position + offset).x;
    //      transform.position = position;
    //  }
 
    //  // Assign this to your UI buttons onClick
    //  public void DoTeleport()
    //  {
    //      float randomY = Random.Range(-10.0f, 10.0f); // Min = -10.0f, Max = 10.0f
    //      float randomX = Random.Range(-10.0f, 10.0f);
    //      offset += new Vector3(randomX, randomY, 0);
    //  }

    //public Transform Player;

    
    // void Start()
    // {
    //     Player = GameObject.FindWithTag("Player");
    // }

    // Proposition: get targetposition manually (via GameObject)


    //public Vector3 targetposition;
    public GameObject targetarea;
    public void teleport()
    {
        //Vector3 target = new Vector3(targetarea.transform.localPosition.x, targetarea.transform.localPosition.y, targetarea.transform.localPosition.z);
        Vector3 target = new Vector3(targetarea.transform.position.x, this.transform.position.y, targetarea.transform.position.z);

        this.transform.localPosition = target;
        //this.transform.localPosition = targetposition;
    }
}
