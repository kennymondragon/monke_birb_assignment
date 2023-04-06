using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapEvent : MonoBehaviour
{
    // want to work with local positions of controllers for startPos and endPos
    // because the rest of rig might be moving if the person is currently flying in the air

    /**
     * Recording Flap Events - only start recording one if speed of controller is faster than minimum threshold 
     * 
     * A successful Flap Event:
     * Player moves a greater distance than the minimum threshold in the time interval
     * 
     * An unsuccessful Flap Event:
     * A Flap Event ends if the distance moved by the controller doesn't break the threshold minimum in the allotted time interval
     */

    // the time interval in which the flap has to travel the minimum distance threshold
    public float timeInterval;
    // the minimum distance threshold for a successful wing flap event
    public float distanceThreshold;

    // can we just use Controller.GetComponent<RigidBody>().Velocity instead?

    // the minimum speed threshold for starting to record a wing flap event
    public float speedThreshold;
    // to calculate speed
    Vector3 curPos;
    Vector3 lastPos;

    // time event started at
    Time timeStarted;
    // the starting position of the flap
    Vector3 startPos;
    // the ending position of the flap event
    Vector3 endPos;

    // public constructor
    FlapEvent()
    {

    }

    private void Update(Transform t)
    {
        
    }

    bool RecordFlapEvent()
    {

        return true;
    }

    Vector3 DoFlapEvent()
    {
        Vector3 forces = Vector3.zero;
        // 
        if (!RecordFlapEvent()) return forces;



        return forces;
    }

    private void OnDestroy()
    {
        
    }

}

public class BirbWings : MonoBehaviour
{
    // the current flap event
    private FlapEvent flap_event;
    // forces that need to be applied to the Player
    Vector3 forces;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if a FlapEvent needs to start being recorded

        // apply any forces to the player in a timely manner with Time.deltaTime

    }

    /**
     * 
     */
    void CaputureFlappingEvent()
    {
        // save point at which 
    }
}
