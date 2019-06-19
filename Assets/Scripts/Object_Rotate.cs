using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Rotate : MonoBehaviour
{
    public Direction[] AttachedPipes = new Direction[2];
    private int _currentAttachedPipe;
    public Object_Rotate CurrentDirection;
    // Start is called before the first frame update
    protected void Start()
    {
        ChangeDirection(AttachedPipes[_currentAttachedPipe]);
    }
    
    void OnMouseDown() 
    {
        if(PauseMenu.GameIsPaused)
            return;

        ChangeDirection(AttachedPipes[_currentAttachedPipe]);
    }

    void ChangeDirection(Direction a_Direction)
    {
        _currentAttachedPipe = (_currentAttachedPipe + 1) % AttachedPipes.Length;
        CurrentDirection = a_Direction.OtherPipe;
        transform.rotation = Quaternion.Euler(0, 0, a_Direction.Rotation.z);
    }
}

[System.Serializable]
public class Direction
{
    public Object_Rotate OtherPipe;
    public Quaternion Rotation;
}