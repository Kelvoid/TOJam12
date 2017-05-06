using UnityEngine;
using System.Collections;

public class NavigationAI : MonoBehaviour {

    public float wanderRadius;
    private float wanderTimer;

    public float minWanderTime;
    public float maxWanderTime;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    Sheep sheep;

    void OnEnable()
    {
        wanderTimer = Random.Range(minWanderTime, maxWanderTime);
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        sheep = GetComponent<Sheep>();
    }

    void Update()
    {
        if(sheep.attentionGrabbed == false)
        {
            timer += Time.deltaTime;
            if (timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
                wanderTimer = Random.Range(minWanderTime, maxWanderTime);
            }
        }

        if(sheep.attentionGrabbed == true)
        {           
            agent.SetDestination(sheep.currentPointofIntrest);
        }

    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
