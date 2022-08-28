using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Doctor_AI : MonoBehaviour
{
    public float aiSpeed;
    public Transform target;
    int nextTarget;

    private void Start()
    {
        target = AiManager.instance.target[nextTarget];
        GetComponent<NavMeshAgent>().speed = aiSpeed;
        StartCoroutine(AI_Move());
    }
    IEnumerator AI_Move()
    {
        GetComponent<NavMeshAgent>().SetDestination(target.position);
        while (true)
        {
            float dis = (target.position = transform.position).magnitude;

            if (dis <= 1)
            {
                nextTarget += 1;
                if(nextTarget >= AiManager.instance.target.Length)
                    nextTarget = 0;

                target = AiManager.instance.target[nextTarget];
            }

            yield return null;
        }
    }
}
