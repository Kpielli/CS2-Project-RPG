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
  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.gameObject.name == "Player")
    {
      if(Input.GetKeyDown(Keycode.Space))
      {
        dMAn.ShowBox(dialogue);
      }
      }
      }
 }
