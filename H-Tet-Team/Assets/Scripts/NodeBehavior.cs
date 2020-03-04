using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBehavior : MonoBehaviour
{
    SpriteRenderer render;
    BoxCollider2D collider;
    Collider2D target;
    Color transparent;
    Color white;
    Color blue;
    Color green;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        transparent = Color.clear;
        white = Color.white;
        blue = Color.blue;
        green = Color.green;

        if (this.CompareTag("Wall"))
        {
            render.color = transparent;
        }
        if (this.CompareTag("Node"))
        {
            render.color = white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
	
        if (this.CompareTag("Node"))
        {
            render.color = blue;
        }
	
        detectNeighbors();

	}

	private void detectNeighbors(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, 2, 0), Vector2.up);

        detectHit(hit, "above");

        hit = Physics2D.Raycast(transform.position + new Vector3(0, -2, 0), -Vector2.up);

        detectHit(hit, "below");

        hit = Physics2D.Raycast(transform.position + new Vector3(2, 0, 0), Vector2.right);

        detectHit(hit, "right");

        hit = Physics2D.Raycast(transform.position + new Vector3(-2, 0, 0), -Vector2.right);

        detectHit(hit, "left");

    }
    private void detectHit(RaycastHit2D hit, string direction){
        if(hit.collider != null){
            Debug.Log("ping " + direction + "!" + hit.collider);

            target = hit.collider;
        }
    }
}
