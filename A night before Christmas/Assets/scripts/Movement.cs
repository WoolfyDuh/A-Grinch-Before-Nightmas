using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : CharacterController
{
    float input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void FixedUpdate()
	{
        input = Input.GetAxis("Horizontal");
        Move(input);
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
