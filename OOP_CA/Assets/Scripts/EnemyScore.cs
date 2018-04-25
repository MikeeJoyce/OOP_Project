 using UnityEngine;
 using System.Collections;
 
 public class EnemyBehaviour : MonoBehaviour
 {
     private ScoreBehaviour scrScript;
     float speed = 5f;
         
     void Start() 
     {
         scrScript = GameObject.Find ("MainCamera").GetComponent<ScoreBehaviour> ();
     }
     
     void Awake()
     {
         Destroy(gameObject, 15f);
     }
 
     void Update ()
     {
         transform.Translate(0, 0, speed * Time.deltaTime);
     }
 
     void OnTriggerEnter(Collider bomb)
     {
         if (bomb.gameObject.tag == "bomb")
         {
             scrScript.KillScore();
             bomb.gameObject.GetComponent<MeshRenderer>().enabled = false;
             Destroy (bomb.gameObject, 0.7f);
             Destroy(this.gameObject);
         }
     }
 }