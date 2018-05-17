using UnityEngine;
using System.Collections;

public class dialogHolder : MonoBehavior {

  public string dialogue;
  private DialogueManager dMAn;
  
  void Start(){
    dMAn = FindObjectOfType<DialogueManager>();
  }
  
  void Update(){
  
  }
  void OnTriggerStay2D(Collider2D other)
  {
    if(other.gameObject.name == "Player")
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        dMAn.ShowBox(dialogue);
      }
    }
   }
 }

//stopped at 16 of vid 28
