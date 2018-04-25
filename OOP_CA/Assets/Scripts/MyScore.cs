 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class ScoreBehaviour : MonoBehaviour
 {
     public static float score;
     public Text scoreText;
 
     void Start()
     {
         score = 0;
     }
 
     void Update()
     {
         score = score + (Time.deltaTime * 27);
         int showscore = (int)score;
         scoreText.text = "Score: " + showscore.ToString ();
     }
 
     public void KillScore()
     {    
         score += 500;
         int showscore = (int)score;
         scoreText.text = "Score: " + showscore.ToString ();
     }
 }