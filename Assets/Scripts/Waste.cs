using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waste : MonoBehaviour
{
    public WasteType WasteType;

    public Object_Rotate StartingPippe;
    private Object_Rotate _currentPipe;
   
    

    private void Start()
    {
        GameObject[] r = GameObject.FindGameObjectsWithTag("StartingPipe");
        Object_Rotate[] t = new Object_Rotate[r.Length];
        for (int i = 0; i < r.Length; i++)
        {
            t[i] = r[i].GetComponent<Object_Rotate>();
        }
        StartingPippe = t[Random.Range(0, t.Length)];
        _currentPipe = StartingPippe;
    }

    public void ChangePipe(Object_Rotate a_Pipe)
    {
        _currentPipe = a_Pipe;
    }

    void Update()
    {
        if(PauseMenu.GameIsPaused)
            return;

        //if(GameManager.Instance.GameOver)
            //return;

            Debug.Log(_currentPipe);

        if(Vector3.Distance(transform.position, _currentPipe.transform.position) < 0.3f)
        {
            if(_currentPipe.GetType() == typeof(Goal))
            {
                Goal g = _currentPipe.GetComponent<Goal>();
                g.CheckWaste(this);
            }
            else
            {
                ChangePipe(_currentPipe.CurrentDirection);
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, _currentPipe.transform.position, 0.05f);
    }
}
