using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.HighDefinition.Attributes;

public class moveFromMidi : MonoBehaviour
{
    public VfxMidi Midi; 
    public float minDistance;

    public float maxDistance;
    // Start is called before the first frame update
    private void Awake()
    {
        Midi = new VfxMidi();
        //Midi.camera.cameraZ.started += ctx => move(ctx.ReadValue<float>());
    }

    void move(float value)
    {
       
    }
    void OnEnable()
    {
        Midi.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        var value = Midi.camera.cameraZ.ReadValue<float>();
        var mapped = Mathf.Lerp(minDistance, maxDistance, value);

        var x = transform.localPosition.x;
        var y = transform.localPosition.y;
        var z = mapped;
        
        transform.localPosition = new Vector3(x,y,z);
    }
}
