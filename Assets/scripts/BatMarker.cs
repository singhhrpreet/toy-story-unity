using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMarker : MonoBehaviour
{
    public BatFollower Robin;

    void Start()
    {
        SpawnFollowers();
    }

    private void SpawnFollowers()
    {
        var follower = Instantiate(Robin);
        follower.transform.position = transform.position;
        follower.SetFollowTarget(this);
    }
}
