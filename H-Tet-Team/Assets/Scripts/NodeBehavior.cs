using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBehavior : MonoBehaviour
{
    SpriteRenderer render;
    BoxCollider2D collider;
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
	
	RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
	if(hit.collider != null){
		Debug.Log("ping!");

		if(render.color == hit.getColor()){
			Debug.Log("Color PIng!");
		}
	}
    }

    public Color getColor(){
	return render.color;
    }
}
