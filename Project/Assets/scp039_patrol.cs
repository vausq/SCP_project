using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scp039_patrol : MonoBehaviour
{
    //variables changeable in unity
    public float speed=2.0f;
    public Transform[] movespots;
    public float waittime;
     
    //fixed within code
    private float startwaittime = 0.5f;
    private int randomspot;

    // Start is called before the first frame update
    void Start()
    {
        randomspot = Random.Range(0, movespots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movespots[randomspot].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, movespots[randomspot].position)<0.2f){
            if(waittime <= 0){
                randomspot = Random.Range(0, movespots.Length);
                waittime = startwaittime;
            }   else {waittime -= Time.deltaTime;}


        }
    
    }
}