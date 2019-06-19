using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {




// Use this for initialization
void Start () {
   
}


// Update is called once per frame
void Update()
{

}
void OnCollisionEnter (Collision coll)
{
        if(this.gameObject.tag == coll.gameObject.tag)
        {
            Debug.Log("Collision detected");
            GameManager.instance.score_ += 10;
            GameManager.instance.TableSpawn();
            Destroy(coll.gameObject);
        }
        else
        {
            Destroy(coll.gameObject);
        }
        GameManager.instance.SpawnObjects();
    }
}
