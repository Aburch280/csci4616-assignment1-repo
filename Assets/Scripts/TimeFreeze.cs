using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{

    public GameObject leftHand;
    public GameObject rightHand;

    public Vector3 prevLeft;
    public Vector3 prevRight;
    public Vector3 posLeft;
    public Vector3 posRight;

    float minSpeed = 0.05f;

    public float factor = 200f;

    float distance;

    float scaledDistance;

    float timeCheck;

    void Start()
    {
        prevLeft = leftHand.transform.position;
        prevRight = rightHand.transform.position;
    }

    void Update()
    {

        posLeft = leftHand.transform.position;
        posRight = rightHand.transform.position;

        if(Vector3.Distance(prevLeft,posLeft) > Vector3.Distance(prevRight,posRight))
        {
            distance = Vector3.Distance(prevLeft,posLeft);
        }
        else
        {
            distance = Vector3.Distance(prevRight,posRight);
        }

        scaledDistance = distance * factor;

        timeCheck = math.max(scaledDistance,minSpeed);
        
        Time.timeScale = math.min(timeCheck,1);

        prevLeft = posLeft;
        
        prevRight = posRight;
    }
}
