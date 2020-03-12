using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    
    Canvas canvas;
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        canvas = GetComponent<Canvas>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FindPath(Vector2 startPos, Vector2 targetPos)
    {
        
    } 
}




public abstract class CustomComponent : Component
{
    public new CustomTransform transform;
}

public class CustomTransform
{
    public Vector3 position
    {
        get
        {
            initialize_transform();
            return transform_reference.position;
        }
        set
        {
            initialize_transform();
            transform_reference.position = value;
            transform_reference.position.Normalize();
        }
    }
    private void initialize_transform()
    {
        if (transform_reference == null)
        {
            transform_reference = this.GetComponent<Transform>();
        }
    }

    Transform transform_reference;
}