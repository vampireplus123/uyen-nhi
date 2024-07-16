using UnityEngine;
using System.Collections;

public class BackGroundController : MonoBehaviour {
	public Renderer Background;
	public float speedBG;
	public Renderer Midground;
	public float speedMG;
	public Renderer Forceground;
	public float speedFG;

	[Tooltip("if this target == null, the target will be Main Camera")]
	public Transform target;
	float startPosX;

	// Use this for initialization
	void Start () {
		if (target == null)
			target = Camera.main.transform;
		
		startPosX = target.position.x;
	}
	
	// Update is called once per frame
	void Update () {
    // Calculate the distance moved by the target
    var x = target.position.x - startPosX;

    // Update background offset
    if (Background != null) {
        var offsetBG = x * speedBG;
        Background.material.mainTextureOffset = new Vector2(offsetBG, Background.material.mainTextureOffset.y);
    }

    // Update midground offset
    if (Midground != null) {
        var offsetMG = x * speedMG;
        Midground.material.mainTextureOffset = new Vector2(offsetMG, Midground.material.mainTextureOffset.y);
    }

    // Update foreground offset
    if (Forceground != null) {
        var offsetFG = x * speedFG;
        Forceground.material.mainTextureOffset = new Vector2(offsetFG, Forceground.material.mainTextureOffset.y);
    }
}

}
