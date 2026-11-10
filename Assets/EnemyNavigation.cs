using UnityEngine;
using UnityEngine.AI; 

public class EnemyNavigation : MonoBehaviour
{


    public NavMeshAgent agent;

    public Transform target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("PlayerCapsule").transform;
        InvokeRepeating("UpdateTarget", 3f ,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateTarget()
    {
        agent.destination = target.position;

    }

    


}


